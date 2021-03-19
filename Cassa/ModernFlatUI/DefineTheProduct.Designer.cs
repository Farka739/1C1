
namespace ModernFlatUI
{
    partial class DefineTheProduct
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
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnAddTheProduct = new System.Windows.Forms.Button();
            this.btnChangeTheProductInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbName
            // 
            this.txtbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbName.Location = new System.Drawing.Point(79, 49);
            this.txtbName.Margin = new System.Windows.Forms.Padding(70, 40, 3, 3);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(552, 22);
            this.txtbName.TabIndex = 0;
            this.txtbName.Text = "Name";
            this.txtbName.Click += new System.EventHandler(this.txtbName_Click);
            this.txtbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbPrice
            // 
            this.txtbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPrice.Location = new System.Drawing.Point(637, 49);
            this.txtbPrice.Margin = new System.Windows.Forms.Padding(3, 40, 3, 3);
            this.txtbPrice.MaximumSize = new System.Drawing.Size(150, 22);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(150, 22);
            this.txtbPrice.TabIndex = 1;
            this.txtbPrice.Text = "Price";
            this.txtbPrice.Click += new System.EventHandler(this.txtbPrice_Click);
            // 
            // txtbDescription
            // 
            this.txtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDescription.Location = new System.Drawing.Point(79, 114);
            this.txtbDescription.Margin = new System.Windows.Forms.Padding(70, 40, 70, 40);
            this.txtbDescription.Multiline = true;
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(795, 270);
            this.txtbDescription.TabIndex = 3;
            this.txtbDescription.Text = "Description";
            this.txtbDescription.Click += new System.EventHandler(this.txtbDescription_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Location = new System.Drawing.Point(793, 49);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 40, 70, 3);
            this.nudQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(81, 22);
            this.nudQuantity.TabIndex = 4;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnProductList
            // 
            this.btnProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductList.Location = new System.Drawing.Point(79, 427);
            this.btnProductList.Margin = new System.Windows.Forms.Padding(70, 3, 3, 40);
            this.btnProductList.MaximumSize = new System.Drawing.Size(150, 40);
            this.btnProductList.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(150, 40);
            this.btnProductList.TabIndex = 5;
            this.btnProductList.Text = "Products List";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnAddTheProduct
            // 
            this.btnAddTheProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTheProduct.Location = new System.Drawing.Point(724, 427);
            this.btnAddTheProduct.Margin = new System.Windows.Forms.Padding(3, 3, 70, 40);
            this.btnAddTheProduct.MaximumSize = new System.Drawing.Size(150, 40);
            this.btnAddTheProduct.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnAddTheProduct.Name = "btnAddTheProduct";
            this.btnAddTheProduct.Size = new System.Drawing.Size(150, 40);
            this.btnAddTheProduct.TabIndex = 6;
            this.btnAddTheProduct.Text = "Add";
            this.btnAddTheProduct.UseVisualStyleBackColor = true;
            this.btnAddTheProduct.Click += new System.EventHandler(this.btnAddTheProduct_Click);
            // 
            // btnChangeTheProductInfo
            // 
            this.btnChangeTheProductInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeTheProductInfo.Enabled = false;
            this.btnChangeTheProductInfo.Location = new System.Drawing.Point(518, 427);
            this.btnChangeTheProductInfo.MaximumSize = new System.Drawing.Size(200, 40);
            this.btnChangeTheProductInfo.MinimumSize = new System.Drawing.Size(200, 40);
            this.btnChangeTheProductInfo.Name = "btnChangeTheProductInfo";
            this.btnChangeTheProductInfo.Size = new System.Drawing.Size(200, 40);
            this.btnChangeTheProductInfo.TabIndex = 7;
            this.btnChangeTheProductInfo.Text = "Change";
            this.btnChangeTheProductInfo.UseVisualStyleBackColor = true;
            this.btnChangeTheProductInfo.Click += new System.EventHandler(this.btnChangeTheProductInfo_Click);
            // 
            // DefineTheProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 516);
            this.Controls.Add(this.btnChangeTheProductInfo);
            this.Controls.Add(this.btnAddTheProduct);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.txtbDescription);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.txtbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DefineTheProduct";
            this.Text = "DefineTheProduct";
            this.Load += new System.EventHandler(this.DefineTheProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtbName;
        public System.Windows.Forms.TextBox txtbPrice;
        public System.Windows.Forms.TextBox txtbDescription;
        public System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnProductList;
        public System.Windows.Forms.Button btnAddTheProduct;
        public System.Windows.Forms.Button btnChangeTheProductInfo;
    }
}