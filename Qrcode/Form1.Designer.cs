
namespace Qrcode
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnPath = new System.Windows.Forms.Button();
            this.BtnPreview = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.BtnImport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnExit = new System.Windows.Forms.Button();
            this.appData1 = new Qrcode.AppData();
            this.lblmessage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path:";
            // 
            // TxtPath
            // 
            this.TxtPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPath.Location = new System.Drawing.Point(81, 17);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ReadOnly = true;
            this.TxtPath.Size = new System.Drawing.Size(802, 35);
            this.TxtPath.TabIndex = 1;
            // 
            // BtnPath
            // 
            this.BtnPath.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPath.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPath.Location = new System.Drawing.Point(879, 14);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(52, 44);
            this.BtnPath.TabIndex = 2;
            this.BtnPath.Text = ".....";
            this.BtnPath.UseVisualStyleBackColor = false;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // BtnPreview
            // 
            this.BtnPreview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreview.Location = new System.Drawing.Point(286, 65);
            this.BtnPreview.Name = "BtnPreview";
            this.BtnPreview.Size = new System.Drawing.Size(175, 51);
            this.BtnPreview.TabIndex = 4;
            this.BtnPreview.Text = "Print/ Preview";
            this.BtnPreview.UseVisualStyleBackColor = true;
            this.BtnPreview.Click += new System.EventHandler(this.BtnPreview_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Location = new System.Drawing.Point(498, 65);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(166, 51);
            this.BtnExport.TabIndex = 5;
            this.BtnExport.Text = "Export to Pdf";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImport.Location = new System.Drawing.Point(937, 14);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(99, 44);
            this.BtnImport.TabIndex = 3;
            this.BtnImport.Text = "Import";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 462);
            this.dataGridView1.TabIndex = 6;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(944, 590);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(121, 51);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Location = new System.Drawing.Point(539, 599);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(73, 32);
            this.lblmessage.TabIndex = 7;
            this.lblmessage.Text = "label";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(5, 590);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(528, 51);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 648);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.BtnPreview);
            this.Controls.Add(this.BtnPath);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.Button BtnPreview;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnExit;
        private AppData appData1;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

