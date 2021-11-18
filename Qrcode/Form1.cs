using ClosedXML.Excel;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qrcode
{
    public partial class Form1 : Form
    {
        private string path;
        private readonly BackgroundWorker _BackgroundWorker = new BackgroundWorker();
        private DataTable dtTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            progressBar1.Visible = false;
            progressBar1.MarqueeAnimationSpeed = 10;
            progressBar1.Style = ProgressBarStyle.Marquee;
            _BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            _BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            //_BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
        }

        //private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
        //    lblmessage.Text = string.Format("SAVING......{0}%", e.ProgressPercentage);
        //    progressBar1.Update();
        //}

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Hide();
            if (MessageBox.Show("TẠO FILE THÀNH CÔNG. BẠN CÓ MUỐN MỞ FILE?", "CREAT PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && File.Exists(path))
            {
                lblmessage.Text = "COMPLETE!";
                Process.Start(path);
            }
        }
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                using (FrmReport frmReport = new FrmReport(this.appData1.QrData))
                {
                    frmReport.SaveToPdf(path);
                }
            }
            catch(Exception ex)
            {
                _BackgroundWorker.CancelAsync();
                _ = MessageBox.Show("TẠO FILE KHÔNG THÀNH CÔNG!" + Environment.NewLine + ex);
            }
        }                
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnExport.Enabled = false;
            BtnImport.Enabled = false;
            lblmessage.Text = "";
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void BtnPath_Click(object sender, EventArgs e)
        {
            lblmessage.Text = "";
            Openfile();
        }
        private async void BtnImport_Click(object sender, EventArgs e)
        {
            dtTable.Clear();
            dataGridView1.DataSource = null;
            await Task.Run(() => ImpDataToDataTable(TxtPath.Text));
            await Task.Run(() => GenerateQrcode());
            dataGridView1.DataSource = appData1.Tables[0];
            BtnExport.Enabled = true;
        }
        private void BtnPreview_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null)
            {
                _ = MessageBox.Show("Chưa import dữ liệu vào bảng!");
            }
            else
            {
                using (FrmReport frmReport = new FrmReport(this.appData1.QrData))
                {
                    frmReport.ShowDialog();
                }
            }
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (!_BackgroundWorker.IsBusy)
            {
                using (SaveFileDialog savefile = new SaveFileDialog() { Filter = "File PDF(*.pdf)|*.pdf", ValidateNames = true })
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        lblmessage.Text = "SAVING......!";
                        //lblmessage.Refresh();
                        path = savefile.FileName;
                        progressBar1.Show();
                        _BackgroundWorker.RunWorkerAsync();
                    }
                }
            }
        }
        private void Openfile()
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { Filter = "ExcelWorbook(*.xls,*.xlsx)|*.xls;*.xlsx|All Files(*.*)|*.*", Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    TxtPath.Text = openFile.FileName;
                    BtnImport.Enabled = true;
                }
            }
        }
        private void ImpDataToDataTable(string path)
        {
            try
            {                
                dtTable = new DataTable();
                using (XLWorkbook workbook = new XLWorkbook(path))
                {
                    IXLWorksheet worksheet = workbook.Worksheet(1);
                    bool firstRow = true;
                    foreach (IXLRow row in worksheet.Rows())
                    {
                        if (firstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dtTable.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }
                        else
                        {
                            dtTable.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                dtTable.Rows[dtTable.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                _ = MessageBox.Show("KHÔNG ĐỌC ĐƯỢC FILE EXCEL HOẶC FILE EXCEL ĐANG MỞ" + Environment.NewLine + ex);
            }
        }
        private void GenerateQrcode()
        {
            try
            {
                if (TxtPath.Text == "")
                {
                    _ = MessageBox.Show("Vui lòng chọn đường dẫn đến file excel");
                }
                else
                {
                    this.appData1.Clear();
                    foreach (DataRow row in dtTable.Rows)
                    {
                        QRCoder.QRCodeGenerator qRCodeGenerator = new QRCoder.QRCodeGenerator();
                        QRCoder.QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(row[7].ToString(), QRCoder.QRCodeGenerator.ECCLevel.Q);
                        QRCoder.QRCode qRCode = new QRCoder.QRCode(qRCodeData);
                        Bitmap bmp = qRCode.GetGraphic(5);
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmp.Save(ms, ImageFormat.Bmp);
                            this.appData1.QrData.AddQrDataRow(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), ms.ToArray());
                        }
                    }
                    _ = MessageBox.Show("IMPORT DỮ LIỆU THÀNH CÔNG!");
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("KHÔNG TẠO ĐƯỢC QRCODE!" + Environment.NewLine + ex);
            }
        }
    }
}
