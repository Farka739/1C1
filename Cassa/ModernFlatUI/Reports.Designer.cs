
namespace ModernFlatUI
{
    partial class Reports
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
            this.txtbStartDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbEndDate = new System.Windows.Forms.TextBox();
            this.rtxtbReportContent = new System.Windows.Forms.RichTextBox();
            this.btnMakeTheReport = new System.Windows.Forms.Button();
            this.btnTop10Products = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the Date period in the DD-MM-YYYY format:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbStartDate
            // 
            this.txtbStartDate.Location = new System.Drawing.Point(59, 68);
            this.txtbStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbStartDate.MaxLength = 10;
            this.txtbStartDate.Name = "txtbStartDate";
            this.txtbStartDate.Size = new System.Drawing.Size(54, 20);
            this.txtbStartDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbEndDate
            // 
            this.txtbEndDate.Location = new System.Drawing.Point(235, 68);
            this.txtbEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbEndDate.MaxLength = 10;
            this.txtbEndDate.Name = "txtbEndDate";
            this.txtbEndDate.Size = new System.Drawing.Size(54, 20);
            this.txtbEndDate.TabIndex = 2;
            this.txtbEndDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbEndDate_KeyUp);
            // 
            // rtxtbReportContent
            // 
            this.rtxtbReportContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtbReportContent.Location = new System.Drawing.Point(59, 117);
            this.rtxtbReportContent.Margin = new System.Windows.Forms.Padding(52, 32, 52, 32);
            this.rtxtbReportContent.Name = "rtxtbReportContent";
            this.rtxtbReportContent.ReadOnly = true;
            this.rtxtbReportContent.Size = new System.Drawing.Size(594, 236);
            this.rtxtbReportContent.TabIndex = 3;
            this.rtxtbReportContent.Text = "";
            // 
            // btnMakeTheReport
            // 
            this.btnMakeTheReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeTheReport.Enabled = false;
            this.btnMakeTheReport.Location = new System.Drawing.Point(540, 388);
            this.btnMakeTheReport.Margin = new System.Windows.Forms.Padding(2, 2, 52, 32);
            this.btnMakeTheReport.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnMakeTheReport.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnMakeTheReport.Name = "btnMakeTheReport";
            this.btnMakeTheReport.Size = new System.Drawing.Size(112, 32);
            this.btnMakeTheReport.TabIndex = 7;
            this.btnMakeTheReport.Text = "Make the Report";
            this.btnMakeTheReport.UseVisualStyleBackColor = true;
            this.btnMakeTheReport.Click += new System.EventHandler(this.btnMakeTheReport_Click);
            // 
            // btnTop10Products
            // 
            this.btnTop10Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTop10Products.Location = new System.Drawing.Point(423, 388);
            this.btnTop10Products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 32);
            this.btnTop10Products.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnTop10Products.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnTop10Products.Name = "btnTop10Products";
            this.btnTop10Products.Size = new System.Drawing.Size(112, 32);
            this.btnTop10Products.TabIndex = 8;
            this.btnTop10Products.Text = "Top 10 Products";
            this.btnTop10Products.UseVisualStyleBackColor = true;
            this.btnTop10Products.Click += new System.EventHandler(this.btnTop10Products_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "End:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(306, 388);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 32);
            this.btnRefresh.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnRefresh.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 32);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "3/29/2021";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(59, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "3/29/2021";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(177, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 460);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTop10Products);
            this.Controls.Add(this.btnMakeTheReport);
            this.Controls.Add(this.txtbEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtbReportContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtbStartDate;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtbEndDate;
        public System.Windows.Forms.RichTextBox rtxtbReportContent;
        public System.Windows.Forms.Button btnMakeTheReport;
        public System.Windows.Forms.Button btnTop10Products;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}