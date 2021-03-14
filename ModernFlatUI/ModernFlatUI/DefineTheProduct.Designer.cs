
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
            this.txtbID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbName
            // 
            this.txtbName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbName.Location = new System.Drawing.Point(175, 100);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(338, 22);
            this.txtbName.TabIndex = 0;
            this.txtbName.Text = "Name";
            this.txtbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbPrice
            // 
            this.txtbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPrice.Location = new System.Drawing.Point(519, 100);
            this.txtbPrice.MaximumSize = new System.Drawing.Size(120, 22);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(120, 22);
            this.txtbPrice.TabIndex = 1;
            this.txtbPrice.Text = "Price";
            // 
            // txtbDescription
            // 
            this.txtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDescription.Location = new System.Drawing.Point(109, 169);
            this.txtbDescription.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.txtbDescription.Multiline = true;
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(617, 200);
            this.txtbDescription.TabIndex = 3;
            this.txtbDescription.Text = "Description";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Location = new System.Drawing.Point(645, 100);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(81, 22);
            this.nudQuantity.TabIndex = 4;
            this.nudQuantity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnProductList
            // 
            this.btnProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProductList.Location = new System.Drawing.Point(109, 411);
            this.btnProductList.MaximumSize = new System.Drawing.Size(150, 40);
            this.btnProductList.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(150, 40);
            this.btnProductList.TabIndex = 5;
            this.btnProductList.Text = "Products List";
            this.btnProductList.UseVisualStyleBackColor = true;
            // 
            // btnAddTheProduct
            // 
            this.btnAddTheProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTheProduct.Location = new System.Drawing.Point(576, 411);
            this.btnAddTheProduct.MaximumSize = new System.Drawing.Size(150, 40);
            this.btnAddTheProduct.MinimumSize = new System.Drawing.Size(150, 40);
            this.btnAddTheProduct.Name = "btnAddTheProduct";
            this.btnAddTheProduct.Size = new System.Drawing.Size(150, 40);
            this.btnAddTheProduct.TabIndex = 6;
            this.btnAddTheProduct.Text = "Add";
            this.btnAddTheProduct.UseVisualStyleBackColor = true;
            this.btnAddTheProduct.Click += new System.EventHandler(this.btnAddTheProduct_Click);
            // 
            // txtbID
            // 
            this.txtbID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbID.Location = new System.Drawing.Point(109, 100);
            this.txtbID.MaximumSize = new System.Drawing.Size(120, 22);
            this.txtbID.Name = "txtbID";
            this.txtbID.Size = new System.Drawing.Size(60, 22);
            this.txtbID.TabIndex = 7;
            this.txtbID.Text = "ID";
            // 
            // DefineTheProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 484);
            this.Controls.Add(this.txtbID);
            this.Controls.Add(this.btnAddTheProduct);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.txtbDescription);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.txtbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DefineTheProduct";
            this.Text = "DefineTheProduct";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnAddTheProduct;
        private System.Windows.Forms.TextBox txtbID;
    }
}