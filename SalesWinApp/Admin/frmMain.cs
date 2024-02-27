using SalesWinApp.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string tmpEmail { get; set; }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmMembers frmMembers = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmMembers.Show();
            }
            else
            {
                frmMembers frmMember = new();
                this.Hide();
                frmMember.Show();
            }
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmProducts frmProducts = new()
                {
                    CurrentRow = 0,
                    CurrentColumn = 0,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmProducts.Show();
            }
            else
            {
                frmProducts frmProducts = new()
                {
                    CurrentRow = 0,
                    CurrentColumn = 0
                };
                this.Hide();
                frmProducts.Show();
            }
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmOrders frmOrders = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmOrders.Show();
            }
            else
            {
                frmOrders frmOrder = new();
                this.Hide();
                frmOrder.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmLogin frmLogin = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmLogin.Show();
            }
            else
            {
                frmLogin frmLogin = new();
                this.Hide();
                frmLogin.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmSalesStatistics frmSalesStatistics = new()
                {
                    isSearched = false,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmSalesStatistics.Show();
            }
            else
            {
                frmSalesStatistics frmSalesStatistics = new()
                {
                    isSearched = false,
                    StartDate = DateTime.Now,
                    EndDate = DateTime.Now
                };
                this.Hide();
                frmSalesStatistics.Show();
            }
        }
    }
}