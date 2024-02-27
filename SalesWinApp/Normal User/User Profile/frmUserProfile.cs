using DataAccess.Models;
using DataAccess.Repository;
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
    public partial class frmUserProfile : Form
    {
        public IMemberRepository _memberRepository;

        public int count = 0;
        public string HidePass = "********";

        public Member Member { get; set; }

        public string tmpEmail { get; set; }

        public frmUserProfile()
        {
            _memberRepository = new MemberRepository();
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUserUpdateProfile frmUserUpdateProfile = new()
                {
                    tmpEmail = tmpEmail,
                    _memberRepository = _memberRepository,
                    Member = Member
                };
                this.Hide();
                frmUserUpdateProfile.Show();
            }
            else
            {
                frmUserMain frmUserMain = new();
                this.Hide();
                frmUserMain.Show();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            Member = _memberRepository.GetMembers().Where(x => x.Email == tmpEmail).FirstOrDefault();
            txtEmail.Text = Member.Email;
            txtPassword.Text = HidePass;
            txtCompanyName.Text = Member.CompanyName;
            txtCity.Text = Member.City;
            txtCountry.Text = Member.Country;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btnShowPassword.Text = "Hide Password";
                txtPassword.Text = Member.Password;
            }
            else
            {
                btnShowPassword.Text = "Show Password";
                txtPassword.Text = HidePass;
            }
            count++;
        }

        private void frmUserProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUserMain frmUserMain = new()
                {
                    tmpEmail = tmpEmail
                };
                frmUserMain.Show();
            }
            else
            {
                frmUserMain frmUserMain = new();
                frmUserMain.Show();
            }
        }
    }
}