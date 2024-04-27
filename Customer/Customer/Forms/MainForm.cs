using Customer.Properties;
using LoanMs.Forms;
using LoanMs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Color primaryColor = Color.FromArgb(32, 85, 131);
        Color secondColor = Color.FromArgb(12, 32, 50);
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            pLoan.Visible = !pLoan.Visible;
            if (pList.Visible == true) pList.Visible = !pList.Visible;
            btnTransaction.BackColor = primaryColor;
            btnListCenter.BackColor = secondColor;
            btnDashboard.BackColor = secondColor;
            btnManagement.ForeColor = Color.White;


            btnLoan.BackColor = secondColor;
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            btnManagement.ForeColor = Color.FromArgb(44, 117, 181);
            btnManagement.Cursor = Cursors.Hand;
        }

        private void btnListCenter_Click(object sender, EventArgs e)
        {
            pList.Visible = !pList.Visible;
            if (pLoan.Visible == true) pLoan.Visible = !pLoan.Visible;
            btnListCenter.BackColor = primaryColor;
            btnTransaction.BackColor = secondColor;
            btnDashboard.BackColor = secondColor;
            btnManagement.ForeColor = Color.White;

            //sublist control
            btnCustomer.BackColor = secondColor;
            btnCollateral.BackColor = secondColor;
            btnCollateralType.BackColor = secondColor;
            btnCreditOfficer.BackColor = secondColor;
        }
        CustomerForm customer;
        private void btnCustomer_Click(object sender, EventArgs e)
        {

            btnCustomer.BackColor = primaryColor;
            btnCollateral.BackColor = secondColor;
            btnCollateralType.BackColor = secondColor;
            btnCreditOfficer.BackColor = secondColor;
            btnManagement.ForeColor = Color.White;
            btnMenu_Click(sender, e);

            if (customer == null)
            {
                customer = new CustomerForm();
                customer.TopLevel = false;
                customer.MdiParent = this;
                this.pContent.Controls.Add(customer);
            }
            customer.BringToFront();
            customer.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (pList.Visible == true) pList.Visible = !pList.Visible;
            if (pLoan.Visible == true) pLoan.Visible = !pLoan.Visible;
            btnDashboard.BackColor = primaryColor;
            btnListCenter.BackColor = secondColor;
            btnTransaction.BackColor = secondColor;
            btnManagement.ForeColor = Color.White;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.FromArgb(44, 117, 181);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            pSidebar.Visible = !pSidebar.Visible;
            if (pSidebar.Visible)
            {
                pSidebar.BringToFront();
                //pNav.BringToFront();
                btnMenu.Image = Resources.close;
            }
            else
            {
                btnMenu.Image = Resources.iconnavigationmenu_24px;
            }
        }

        private void btnManagement_MouseHover(object sender, EventArgs e)
        {
            btnManagement.Cursor = Cursors.Hand;
            btnManagement.ForeColor = Color.FromArgb(44, 117, 181);
        }

        private void btnManagement_MouseMove(object sender, MouseEventArgs e)
        {
            btnManagement.ForeColor = Color.White;
        }

        private void lblLogout_MouseHover(object sender, EventArgs e)
        {
            lblLogout.Cursor = Cursors.Hand;
            lblLogout.ForeColor = Color.FromArgb(44, 117, 181);
        }

        private void lblLogout_MouseLeave(object sender, EventArgs e)
        {
            lblLogout.ForeColor = Color.White;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
