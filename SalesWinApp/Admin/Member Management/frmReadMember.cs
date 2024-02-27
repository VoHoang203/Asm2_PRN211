using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.Member_Management
{
    public partial class frmReadMember : Form
    {
        public string tmpEmail { get; set; }

        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public Member Member { get; set; }

        public frmReadMember()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReadMember_Load(object sender, EventArgs e)
        {
            txtMemberID.Text = Member.MemberId.ToString();
            txtEmail.Text = Member.Email;
            txtCompanyName.Text = Member.CompanyName;
            txtCity.Text = Member.City;
            txtCountry.Text = Member.Country;
        }

        private void frmReadMember_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmMembers frmMembers = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail
                };
                frmMembers.Show();
            }
            else
            {
                frmMembers frmMembers = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn
                };
                frmMembers.Show();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}