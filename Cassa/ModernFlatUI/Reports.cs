using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public static string ReportsFolderPath = Environment.CurrentDirectory + "\\Reports";
        public static string ReportPath = Environment.CurrentDirectory + "\\Report.txt";

        //string line = File.ReadLines(Path + "\\20-03-2021-17-06-55.txt").Skip(2).Take(1).First();
        private int _counter = 1; 

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

       
         private static string NextFile(string path, ref int counter)
        {
            
            var filePath = Directory.EnumerateFiles(path).Skip(counter).First();
            if (filePath != null) return filePath;
            counter = 0;
            return null;
           
        }

        private void btnMakeTheReport_Click(object sender, EventArgs e)
        {
            var startDate = txtbStartDate.Text;
            var endDate = txtbEndDate.Text;

            var hdDirectoryInWhichToSearch = new DirectoryInfo(Path);
            var startDateFiles = hdDirectoryInWhichToSearch.GetFiles("*" + startDate + "*.*");
            var endDateFiles = hdDirectoryInWhichToSearch.GetFiles("*" + endDate + "*.*");
            var startFile = startDateFiles[0].ToString();
            var endFile = endDateFiles[endDateFiles.Length - 1].ToString();

            Directory.GetFiles(Path).Select(f => new FileInfo(f)).OrderBy(f => f.CreationTime);
            File.Copy( Path + "\\" + startFile, ReportPath, true);
            var allReportLines = File.ReadAllLines(ReportPath).ToList();
            allReportLines.Insert(2, startDate);

           /* using (var reportFile = File.AppendText(Path + "\\Report.txt"))
            using (var initialFile = new StreamReader(Path + $"\\{startFile}"))
            {
                reportFile.Write(initialFile);
            }*/

            while (startFile != endFile)
            {
              
                //using (var reportFile = File.AppendText(reportPath))
                using (var currentFile = new StreamReader(NextFile(Path, ref _counter)))
                {
                    var firstString = currentFile.ReadLine();
                    if (firstString != null)
                    {
                        var b = new char[firstString.Length - 7]; 
                        for (var i = 7; i < firstString.Length; i++)
                        {
                            b[i - 7] = firstString[i];
                        }
                        var totalSumPlus = new string(b);
                    

                        var totalSum = allReportLines[0].Substring(7, allReportLines[0].Length - 7);
                        totalSum = (double.Parse(totalSum) + double.Parse(totalSumPlus)).ToString(CultureInfo.InvariantCulture);
                        allReportLines[0] = allReportLines[0].Remove(7).Insert(7, totalSum);
                    }

                    if (Directory.GetFiles(Path).Length != _counter + 1)
                    {
                        var checkToWriteDataCounter = _counter + 1;
                        if (NextFile(Path, ref _counter) != NextFile(Path, ref checkToWriteDataCounter))
                        {
                            allReportLines.Add(NextFile(Path, ref _counter).Substring(Path.Length + 1).Remove(10));
                        }
                    }

                    for (var i = 2; i < File.ReadAllLines(NextFile(Path, ref _counter)).Length; i++)
                    {
                        allReportLines.Add(File.ReadLines(NextFile(Path, ref _counter)).Skip(i).Take(1).First());
                    }


                }
                if (NextFile(Path, ref _counter) == Path + "\\" + endFile)
                {
                    startFile = endFile;
                    _counter = 0;
                }
                if (Directory.GetFiles(Path).Length == _counter + 1)
                    return;
                _counter++;

            }
            File.WriteAllLines(ReportPath, allReportLines);

            var nameofthefile = ReportsFolderPath + "\\" + DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss", new CultureInfo("en-US")) + ".txt";
            using (TextWriter tw = new StreamWriter(nameofthefile))
            {
                foreach (var line in allReportLines)
                {
                   tw.WriteLine(line);
                }
            }

            foreach (var line in allReportLines)
            {
                rtxtbReportContent.AppendText(line + "\r\n");
            }
            /*
            var yStart = (startDate[6] - '0').ToString() + (startDate[7] - '0').ToString() + (startDate[8] - '0').ToString() + (startDate[9] - '0').ToString();
            var yEnd = (endDate[6] - '0').ToString() + (endDate[7] - '0').ToString() + (endDate[8] - '0').ToString() + (endDate[9] - '0').ToString();
            var mStart = (startDate[3] -'0').ToString() + (startDate[4] - '0').ToString(); 
            var mEnd = (endDate[3] - '0').ToString() + (endDate[4] - '0').ToString();
            var dStart = (startDate[0] - '0').ToString() + (startDate[1] - '0').ToString();
            var dEnd = (endDate[0] - '0').ToString() + (endDate[1] - '0').ToString();
*/
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
            if (txtbStartDate.Text.Length == 10 && txtbEndDate.Text.Length == 10 && (txtbStartDate.Text[6] - '0' > txtbEndDate.Text[6] - '0'))
                btnMakeTheReport.Enabled = false;
            if (txtbEndDate.Text.Length == 10 && txtbEndDate.Text[3] == '1' && txtbEndDate.Text[4] - '0' >= 3)
                btnMakeTheReport.Enabled = false;
        }
    }
}
