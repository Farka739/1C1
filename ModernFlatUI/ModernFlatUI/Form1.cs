using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernFlatUI
{
    public partial class Form1 : Form
    {
        Form frmDefineTheProduct = new DefineTheProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
        Form frmListofProducts2 = new ListofProducts2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


        public Form1()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            pnlProductMaintenance.Visible = false;
            pnlReports.Visible = false;
        }

        private void HideSubMenu()
        {
            if (pnlProductMaintenance.Visible == true)
                pnlProductMaintenance.Visible = false;
            if (pnlReports.Visible == true)
                pnlReports.Visible = false;
        }

        private void ShowSubMenu(Control subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void ShowFormDefineTheProduct()
        {

            pnlMain.Controls.Add(frmDefineTheProduct);
            frmDefineTheProduct.Show();
        }

        private void ShowFormListofProducts2()
        {

            pnlMain.Controls.Add(frmListofProducts2);
            frmListofProducts2.Show();
        }

        #region Reports
        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlReports);
        }

        private void btnTotalSalesReport_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void btnTenMostSoldItems_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion
        
        #region ProductMaintenance
        private void btnDefineTheProduct_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowFormDefineTheProduct(); 
        }

        private void btnListOfProducts_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ShowFormListofProducts2();
        }

        private void btnProductMaintenance_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProductMaintenance);
        }
        #endregion

        private void btnCashRegister_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
