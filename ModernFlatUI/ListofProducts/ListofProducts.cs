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

namespace ListofProducts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void dataloadwindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Description", typeof(string));

            dataloadwindow.DataSource = table;
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Stanislav\source\repos\1C1\ModernFlatUI\ModernFlatUI\bin\Debug\ProductList.txt");
            string[] values;

            for(int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(' ');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
    }
}
