using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Normal_User
{
    public partial class frmUserMain : Form
    {
        public string tmpEmail { get; set; }

        public frmUserMain()
        {
            InitializeComponent();
        }

        private void frmUserMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUserOrders frmUserOrders = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmUserOrders.Show();
            }
            else
            {
                frmUserOrders frmUserOrders = new();
                this.Hide();
                frmUserOrders.Show();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUserProfile frmUserProfile = new()
                {
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmUserProfile.Show();
            }
            else
            {
                frmUserProfile frmUserProfile = new();
                this.Hide();
                frmUserProfile.Show();
            }
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

    }
}