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

namespace ModernFlatUI
{
   
    public partial class DefineTheProduct : Form
    {

        public string Path = Environment.CurrentDirectory + "\\ProductList.txt";
        /* private readonly Form1 _form1 = new Form1(); */

        public DefineTheProduct()
        {
            InitializeComponent();
        }

        private string GetTheProduct()
        {
            
            var productInfo =  txtbName.Text + '/' + txtbPrice.Text + '/' + nudQuantity.Text + '/' + txtbDescription.Text;
            return productInfo;
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
            ProductList.frmProductList.RefreshGrid();
            
        }

        private void DefineTheProduct_Load(object sender, EventArgs e)
        {

        }


        private void btnProductList_Click(object sender, EventArgs e)
        {
            Form1.form1.pnlMain.Controls.Clear();
            Form1.form1.ShowFormProductList();
            
        }
        
    }
}
