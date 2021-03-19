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
using static ModernFlatUI.DefineTheProduct;
using static ModernFlatUI.MainForm;

namespace ModernFlatUI
{
    

    public partial class ProductList : Form
    {

        public string Path = Environment.CurrentDirectory + "\\OldProductList.txt";
        public string TempPath = Environment.CurrentDirectory + "\\TempFile.txt";

        internal static ProductList FrmProductList;


        public struct Product
        {
            public string Name;
            public string Price;
            public string Quantity;
            public string Description;

            public Product(string name, string price, string quantity, string description)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                Description = description;
            }
        }

        public readonly List<Product> products = new List<Product>();

        private void GetTheProductInfo()
        {
            var lines = File.ReadAllLines(Path);
            foreach (var line in lines)
            {
                var values = line.Split('/');
                products.Add(new Product(values[0], values[1], values[2], values[3]));
            }
        }

        public ProductList()
        {
            InitializeComponent();
            FrmProductList = this;
        }

        public void RefreshGrid()
        {
            dgvProductList.Rows.Clear();
            dgvProductList.Refresh();
            products.Clear();
            GetTheProductInfo();
            for (var i = 0; i < products.Count; i++)
            {
                dgvProductList.Rows.Add(products[i].Name, products[i].Price, products[i].Quantity, products[i].Description);
            }
            dgvProductList.Refresh(); 
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            dgvProductList.AllowUserToAddRows = false;
            GetTheProductInfo();
           
            for (var i = 0; i < products.Count; i++)
            {
                dgvProductList.Rows.Add(products[i].Name, products[i].Price, products[i].Quantity, products[i].Description);
            }
        }


        private void dgvProductList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = dgvProductList.CurrentCell.ColumnIndex;
            var rowIndex = dgvProductList.CurrentCell.RowIndex;
            var cellValue = (string) dgvProductList.CurrentCell.Value;
            switch (columnIndex)
            {
                case 0:
                    products[rowIndex] =
                        new Product(cellValue, products[rowIndex].Price, products[rowIndex].Quantity,
                            products[rowIndex].Description);
                    break;
                case 1:
                    products[rowIndex] =
                        new Product(products[rowIndex].Name, cellValue, products[rowIndex].Quantity,
                            products[rowIndex].Description);
                    break;
                case 2:
                    products[rowIndex] =
                        new Product(products[rowIndex].Name, products[rowIndex].Price, cellValue,
                            products[rowIndex].Description);
                    break;
                case 3:
                    products[rowIndex] =
                        new Product(products[rowIndex].Name, products[rowIndex].Price, products[rowIndex].Quantity,
                            cellValue);
                    break;

            }

            var newLine = products[rowIndex];
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
        }
        
        private void btnOpenTheDescription_Click(object sender, EventArgs e)
        {
           /* dgvProductList.Controls.Clear();
            var fullDescription = new TextBox
            {
                Location = new Point(),
                Multiline = true,
                Size = new Size(200, 25),
                Text = dgvProductList.CurrentCell.Value.ToString(),

            };
            fullDescription.Left = (dgvProductList.Width - fullDescription.Width) / 2;
            fullDescription.Top = (dgvProductList.Height - fullDescription.Height) / 2;
            dgvProductList.Controls.Add(fullDescription);*/
           MessageBox.Show(dgvProductList.CurrentCell.Value.ToString().Replace(@"\n", "\r\n"));


        }

        private void btnBackToDefine_Click(object sender, EventArgs e)
        {
            FrmDefineTheProduct.ClearTheInfoInDefineTheProduct();
            FrmDefineTheProduct.btnAddTheProduct.Enabled = true;
            FrmDefineTheProduct.btnChangeTheProductInfo.Enabled = false;
            MainForm.Mainform.pnlMain.Controls.Clear();
            MainForm.Mainform.ShowFormDefineTheProduct();
        }

       

        private void btnChangeTheInfo_Click(object sender, EventArgs e)
        {
            var newLine = products[dgvProductList.CurrentCell.RowIndex];
            DefineTheProduct.FrmDefineTheProduct.txtbName.Text = newLine.Name;
            DefineTheProduct.FrmDefineTheProduct.txtbPrice.Text = newLine.Price;
            DefineTheProduct.FrmDefineTheProduct.nudQuantity.Text = newLine.Quantity;
            DefineTheProduct.FrmDefineTheProduct.txtbDescription.Text = newLine.Description.Replace(@"\n", "\r\n"); ;
            DefineTheProduct.FrmDefineTheProduct.btnChangeTheProductInfo.Enabled = true;
            DefineTheProduct.FrmDefineTheProduct.btnAddTheProduct.Enabled = false;
            MainForm.Mainform.pnlMain.Controls.Clear();
            MainForm.Mainform.ShowFormDefineTheProduct();
            
        }
    }
}
