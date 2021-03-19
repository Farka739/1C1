using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static ModernFlatUI.ProductList;

namespace ModernFlatUI
{
   
    public partial class DefineTheProduct : Form
    {

        public string Path = Environment.CurrentDirectory + "\\ProductList.txt";
        public string TempPath = Environment.CurrentDirectory + "\\TempFile.txt";

        internal static DefineTheProduct FrmDefineTheProduct;

        public DefineTheProduct()
        {
            InitializeComponent();
            FrmDefineTheProduct = this;
        }

        private string GetTheProduct()
        {
            
            var productInfo =  txtbName.Text + '/' + txtbPrice.Text + '/' + nudQuantity.Text + '/' + txtbDescription.Text.Replace("\r", string.Empty).Replace("\n", @"\n");
            return productInfo;
        }
        public void ClearTheInfoInDefineTheProduct()
        {
            txtbName.Text = @"Name";
            txtbPrice.Text = @"Price";
            nudQuantity.Value = 0;
            txtbDescription.Text = @"Description";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTheProduct_Click(object sender, EventArgs e)
        {
            using (var productsList = File.AppendText(Path))
            {
                productsList.WriteLine(GetTheProduct());
            }
            ProductList.FrmProductList.RefreshGrid();
            
        }

        private void DefineTheProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            Form1.form1.pnlMain.Controls.Clear();
            Form1.form1.ShowFormProductList();
            
        }

        private void btnChangeTheProductInfo_Click(object sender, EventArgs e)
        {
            var rowIndex = FrmProductList.dgvProductList.CurrentCell.RowIndex;

            FrmProductList.products[rowIndex] =
                new Product(txtbName.Text, txtbPrice.Text, nudQuantity.Text, txtbDescription.Text.Replace("\r", string.Empty).Replace("\n", @"\n"));


            var newLine = FrmProductList.products[rowIndex];
            var lineToWrite = newLine.Name + '/' + newLine.Price + '/' + newLine.Quantity + '/' + newLine.Description;
            var lineNumber = 0;
            using (var reader = new StreamReader(Path))
            using (var writer = new StreamWriter(TempPath))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(lineNumber == rowIndex ? lineToWrite : line);
                    lineNumber++;
                }
            }
            var arrLine = File.ReadAllLines(TempPath);
            File.WriteAllLines(Path, arrLine);
            FrmProductList.dgvProductList.Rows.RemoveAt(rowIndex);
            FrmProductList.dgvProductList.Rows.Insert(rowIndex, newLine.Name, newLine.Price, newLine.Quantity, newLine.Description);
        }

        private void txtbName_Click(object sender, EventArgs e)
        {
            if (txtbName.Text == @"Name")
                txtbName.SelectAll();
        }

        private void txtbPrice_Click(object sender, EventArgs e)
        {
            if (txtbPrice.Text == @"Price")
                txtbPrice.SelectAll();
        }

        private void txtbDescription_Click(object sender, EventArgs e)
        {
            if (txtbDescription.Text == @"Description")
                txtbDescription.SelectAll();
        }
    }
}
