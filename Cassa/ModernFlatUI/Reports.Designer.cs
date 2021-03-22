
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the Date period in the DD-MM-YYYY format:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbStartDate
            // 
            this.txtbStartDate.Location = new System.Drawing.Point(79, 84);
            this.txtbStartDate.MaxLength = 10;
            this.txtbStartDate.Name = "txtbStartDate";
            this.txtbStartDate.Size = new System.Drawing.Size(70, 22);
            this.txtbStartDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbEndDate
            // 
            this.txtbEndDate.Location = new System.Drawing.Point(174, 84);
            this.txtbEndDate.MaxLength = 10;
            this.txtbEndDate.Name = "txtbEndDate";
            this.txtbEndDate.Size = new System.Drawing.Size(70, 22);
            this.txtbEndDate.TabIndex = 2;
            this.txtbEndDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbEndDate_KeyUp);
            // 
            // rtxtbReportContent
            // 
            this.rtxtbReportContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtbReportContent.Location = new System.Drawing.Point(79, 144);
            this.rtxtbReportContent.Margin = new System.Windows.Forms.Padding(70, 40, 70, 40);
            this.rtxtbReportContent.Name = "rtxtbReportContent";
            this.rtxtbReportContent.ReadOnly = true;
            this.rtxtbReportContent.Size = new System.Drawing.Size(791, 290);
            this.rtxtbReportContent.TabIndex = 3;
            this.rtxtbReportContent.Text = "";
            // 
            // btnMakeTheReport
            // 
            this.btnMakeTheReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMakeTheReport.Enabled = false;
            this.btnMakeTheReport.Location = new System.Drawing.Point(720, 477);
            this.btnMakeTheReport.Margin = new System.Windows.Forms.Padding(3, 3, 70, 40);
            this.btnMakeTheReport.MaximumSize = new System.Drawing.Size(150, 40);
            this.btnMakeTheReport.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnMakeTheReport.Name = "btnMakeTheReport";
            this.btnMakeTheReport.Size = new System.Drawing.Size(150, 40);
            this.btnMakeTheReport.TabIndex = 7;
            this.btnMakeTheReport.Text = "Make the Report";
            this.btnMakeTheReport.UseVisualStyleBackColor = true;
            this.btnMakeTheReport.Click += new System.EventHandler(this.btnMakeTheReport_Click);
            // 
            // btnTop10Products
            // 
            this.btnTop10Products.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTop10Products.Location = new System.Drawing.Point(564, 477);
            this.btnTop10Products.Margin = new System.Windows.Forms.Padding(3, 3, 3, 40);
            this.btnTop10Products.MaximumSize = new System.Drawing.Size(150, 40);
            this.btnTop10Products.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnTop10Products.Name = "btnTop10Products";
            this.btnTop10Products.Size = new System.Drawing.Size(150, 40);
            this.btnTop10Products.TabIndex = 8;
            this.btnTop10Products.Text = "Top 10 Products";
            this.btnTop10Products.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "End:";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 566);
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
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbEndDate;
        private System.Windows.Forms.RichTextBox rtxtbReportContent;
        public System.Windows.Forms.Button btnMakeTheReport;
        public System.Windows.Forms.Button btnTop10Products;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}