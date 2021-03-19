using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ModernFlatUI.ProductList;
using static ModernFlatUI.DefineTheProduct;
using static ModernFlatUI.Form1;

namespace ModernFlatUI
{
    public partial class MainForm : Form
    {
        private readonly Form _frmDefineTheProduct = new DefineTheProduct() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
        private readonly Form _frmProductList = new ProductList() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        private readonly Form _frmCashRegisterSystem = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        internal static MainForm Mainform;

        public MainForm()
        {
            InitializeComponent();
            Mainform = this;
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            pnlProductMaintenance.Visible = false;
            pnlReports.Visible = false;
        }

        public void HideSubMenu()
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

        public void ShowFormDefineTheProduct()
        {
            /////
            pnlMain.Controls.Add(_frmDefineTheProduct);
            _frmDefineTheProduct.Show();
        }

        public void ShowFormProductList()
        {

            pnlMain.Controls.Add(_frmProductList);
            _frmProductList.Show();
        }

        public void ShowFormCashRegisterSystem()
        {
            pnlMain.Controls.Add(_frmCashRegisterSystem);
            _frmCashRegisterSystem.Show();
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
            FrmDefineTheProduct.ClearTheInfoInDefineTheProduct();
            FrmDefineTheProduct.btnAddTheProduct.Enabled = true;
            FrmDefineTheProduct.btnChangeTheProductInfo.Enabled = false;
            pnlMain.Controls.Clear(); 
            ShowFormDefineTheProduct(); 
        }

        private void btnListOfProducts_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            pnlMain.Controls.Clear();
            ShowFormProductList(); 
        }

        private void btnProductMaintenance_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlProductMaintenance);
        }
        #endregion

        private void btnCashRegister_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            pnlMain.Controls.Clear();
            ShowFormCashRegisterSystem();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
     
    }
}
