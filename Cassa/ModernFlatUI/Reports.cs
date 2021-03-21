using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernFlatUI
{
    public partial class Reports : Form
    {

        public static string Path = Environment.CurrentDirectory + "\\Receipts";
        string line = File.ReadLines(Path + "\\20-03-2021-17-06-55.txt").Skip(2).Take(1).First();
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMakeTheReport_Click(object sender, EventArgs e)
        {
            var startDate = txtbStartDate.Text;
            var endDate = txtbEndDate.Text;

            var yStart = (startDate[6] - '0').ToString() + (startDate[7] - '0').ToString() + (startDate[8] - '0').ToString() + (startDate[9] - '0').ToString();
            var yEnd = (endDate[6] - '0').ToString() + (endDate[7] - '0').ToString() + (endDate[8] - '0').ToString() + (endDate[9] - '0').ToString();
            var mStart = (startDate[3] -'0').ToString() + (startDate[4] - '0').ToString(); 
            var mEnd = (endDate[3] - '0').ToString() + (endDate[4] - '0').ToString();
            var dStart = (startDate[0] - '0').ToString() + (startDate[1] - '0').ToString();
            var dEnd = (endDate[0] - '0').ToString() + (endDate[1] - '0').ToString();

           /* using (var reportFile = File.Create(Path + "\\"))
            {

            }*/

            /*while (int.Parse(yStart) <= int.Parse(yEnd))
            {
                for (var i = 0; i < 365; i++)
                {
                    while (int.Parse(mStart) <= int.Parse(mEnd))
                    {
                        for (var j = 0; j < 30; j++)
                        {
                            while (int.Parse(dStart) <= int.Parse(dEnd))
                            {
                                rtxtbReportContent.Text += '1';
                                dStart = (int.Parse(dStart) + 1).ToString();
                            }
                        }
                        mStart = (int.Parse(mStart) + 1).ToString();
                    }
                }
                yStart = (int.Parse(yStart) + 1).ToString();
            }*/


           /* for (int.Parse(yStart); int.Parse(yStart) < int.Parse(yEnd); yStartI++)    
            {
                for (mStart = startDate[3] - '0' + startDate[4] - '0'; mStart < mEnd; mStart++)
                {
                    for (dStart = startDate[0] - '0' + startDate[1] - '0'; dStart < dEnd; dStart++)
                    {
                        using (var reportFile = File.Create(Path + "\\"))
                        {

                        }
                    }
                }
            }*/
        }

        

        private void txtbEndDate_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtbStartDate.Text.Length == 10 && txtbEndDate.Text.Length == 10)
            {
                if (txtbStartDate.Text[2] == '-' &&
                    txtbStartDate.Text[5] == '-' && txtbEndDate.Text[2] == '-' && txtbEndDate.Text[5] == '-' &&
                    txtbStartDate.Text[0] - '0' <= 3 && txtbStartDate.Text[3] - '0' <= 1 && txtbEndDate.Text[0] - '0' <= 3 &&
                    txtbEndDate.Text[3] - '0' <= 1)
                    btnMakeTheReport.Enabled = true;
            }
            if (txtbStartDate.Text.Length == 10 && txtbStartDate.Text[3] == '1' && txtbStartDate.Text[4] - '0' >= 3)
                btnMakeTheReport.Enabled = false;
            if (txtbEndDate.Text.Length == 10 && txtbEndDate.Text[3] == '1' && txtbEndDate.Text[4] - '0' >= 3)
                btnMakeTheReport.Enabled = false;
        }
    }
}
