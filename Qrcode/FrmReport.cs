using Microsoft.Reporting.WinForms;
using System;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Qrcode
{
    public partial class FrmReport : Form
    {
        private readonly AppData.QrDataDataTable _qrcode;
        public FrmReport(AppData.QrDataDataTable qrcode)
        {
            InitializeComponent();
            _qrcode = qrcode;
        }
        public void SaveToPdf(string savePath)
        {
            LoadDataToReportView();
            byte[] rBytes;
            string deviceInfo =
            "<DeviceInfo>" +
            "  <OutputFormat>EMF</OutputFormat>" +
            "  <PageWidth>8.5in</PageWidth>" +
            "  <PageHeight>10in</PageHeight>" +
            "  <MarginTop>0.7in</MarginTop>" +
            "  <MarginLeft>0.5in</MarginLeft>" +
            "  <MarginRight>0.1in</MarginRight>" +
            "  <MarginBottom>0.5in</MarginBottom>" +
            "</DeviceInfo>";
            //string savePath = @"C:\Users\Admin\Desktop\duong nq\test.pdf";
            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                rBytes = reportViewer.LocalReport.Render("PDF", deviceInfo, out string minetype, out string encod, out string fextension, out string[] streamids, out Warning[] warnings);
                //MessageBox.Show("so trang la {0}" rBytes.Length());
                stream.Write(rBytes, 0, rBytes.Length);
            }
        }
        private void FrmReport_Load(object sender, EventArgs e)
        {
            LoadDataToReportView();
        }

        private void LoadDataToReportView()
        {
            try
            {
                ReportDataSource reportDataSource = new ReportDataSource
                {
                    Name = "AppDataSet",
                    Value = _qrcode
                };
                reportViewer.LocalReport.EnableExternalImages = true;
                //reportViewer.LocalReport.ReportPath = Application.StartupPath + @"\QrReport.rdlc";                
                PageSettings pg = new PageSettings
                {
                    Margins = new Margins(50, 10, 70, 50),
                    Landscape = false,
                    PaperSize = new PaperSize("Custom", 850, 1000)
                };
                //pg.PaperSize.RawKind = (int)PaperKind.Custom;                
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.SetPageSettings(pg);
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.RefreshReport();
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.PageWidth;
            }
            catch (Exception ex)
            {
                MessageBox.Show("KHÔNG LOAD ĐƯỢC BÁO CÁO!" + Environment.NewLine + ex);
            }
        }        
    }
}
