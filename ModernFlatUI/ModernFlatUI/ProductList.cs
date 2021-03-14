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
    

    public partial class ProductList : Form
    {

        public string Path = Environment.CurrentDirectory + "\\ProductList.txt";
        internal static ProductList frmProductList;


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

        readonly List<Product> products = new List<Product>();

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
            frmProductList = this;
        }

        public void RefreshGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            products.Clear();
            GetTheProductInfo();
            for (var i = 0; i < products.Count; i++)
            {
                dataGridView1.Rows.Add(products[i].Name, products[i].Price, products[i].Quantity, products[i].Description);
            }
            dataGridView1.Refresh(); 
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            GetTheProductInfo();
           
            for (var i = 0; i < products.Count; i++)
            {
                dataGridView1.Rows.Add(products[i].Name, products[i].Price, products[i].Quantity, products[i].Description);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
