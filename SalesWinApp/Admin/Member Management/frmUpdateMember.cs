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

namespace SalesWinApp.Admin.Member_Management
{
    public partial class frmUpdateMember : Form
    {
        public IMemberRepository _memberRepository;

        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public string tmpEmail { get; set; }

        public Member Member { get; set; }

        public frmUpdateMember()
        {
            _memberRepository = new MemberRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateMember_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            txtMemberID.Text = Member.MemberId.ToString();
            txtEmail.Text = Member.Email;
            txtCompanyName.Text = Member.CompanyName;
            txtCity.Text = Member.City;
            txtCountry.Text = Member.Country;
            if (Member.Email == "admin@fstore.com")
            {
                var admin = _memberRepository.GetMembers().SingleOrDefault(c => c.Email == Member.Email);
                txtPassword.Text = admin.Password;
                txtPassword.ReadOnly = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var updateMember = _memberRepository.GetMembers().SingleOrDefault(c => c.Email == Member.Email);
            if (updateMember != null)
            {
                if (txtCompanyName.Text != "" && txtCity.Text != "" && txtCountry.Text != "")
                {
                    updateMember.MemberId = int.Parse(txtMemberID.Text);
                    updateMember.Email = txtEmail.Text;
                    updateMember.CompanyName = txtCompanyName.Text;
                    updateMember.City = txtCity.Text;
                    updateMember.Country = txtCountry.Text;
                    if (tmpEmail == "admin@fstore.com")
                    {
                        updateMember.Password = txtPassword.Text;
                    }
                    _memberRepository.Update();
                    MessageBox.Show("Update successfully!");
                    btnClose_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("All fields are required!");
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}