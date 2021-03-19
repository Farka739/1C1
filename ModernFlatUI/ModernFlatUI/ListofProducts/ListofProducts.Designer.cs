
namespace ListofProducts
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
            this.dataloadwindow = new System.Windows.Forms.DataGridView();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnAddTheProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataloadwindow)).BeginInit();
            this.SuspendLayout();
            // 
            // dataloadwindow
            // 
            this.dataloadwindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataloadwindow.Location = new System.Drawing.Point(12, 12);
            this.dataloadwindow.Name = "dataloadwindow";
            this.dataloadwindow.Size = new System.Drawing.Size(776, 335);
            this.dataloadwindow.TabIndex = 0;
            this.dataloadwindow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataloadwindow_CellContentClick);
            // 
            // btnProductList
            // 
            this.btnProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductList.Location = new System.Drawing.Point(67, 386);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductList.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnProductList.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(112, 32);
            this.btnProductList.TabIndex = 6;
            this.btnProductList.Text = "Products List";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnAddTheProduct
            // 
            this.btnAddTheProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTheProduct.Location = new System.Drawing.Point(603, 386);
            this.btnAddTheProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTheProduct.MaximumSize = new System.Drawing.Size(112, 32);
            this.btnAddTheProduct.MinimumSize = new System.Drawing.Size(112, 32);
            this.btnAddTheProduct.Name = "btnAddTheProduct";
            this.btnAddTheProduct.Size = new System.Drawing.Size(112, 32);
            this.btnAddTheProduct.TabIndex = 7;
            this.btnAddTheProduct.Text = "Add";
            this.btnAddTheProduct.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTheProduct);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.dataloadwindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataloadwindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataloadwindow;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnAddTheProduct;
    }
}

