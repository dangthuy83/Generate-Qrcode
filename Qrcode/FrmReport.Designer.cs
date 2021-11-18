
namespace Qrcode
{
    partial class FrmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.QrDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AppData = new Qrcode.AppData();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QrDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).BeginInit();
            this.SuspendLayout();
            // 
            // QrDataBindingSource
            // 
            this.QrDataBindingSource.DataMember = "QrData";
            this.QrDataBindingSource.DataSource = this.AppData;
            // 
            // AppData
            // 
            this.AppData.DataSetName = "AppData";
            this.AppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AppDataSet";
            reportDataSource1.Value = this.QrDataBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Qrcode.QrReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(848, 928);
            this.reportViewer.TabIndex = 0;
            //this.reportViewer.RenderingBegin += new System.ComponentModel.CancelEventHandler(this.reportViewer_RenderingBegin);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 928);
            this.Controls.Add(this.reportViewer);
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.FrmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QrDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource QrDataBindingSource;
        private AppData AppData;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}