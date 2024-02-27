using DataAccess.Repository;
using SalesWinApp.Normal_User;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.Windows.Forms;
using System;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository _memberRepository;

        public string tmpEmail { get; set; }

        public frmLogin()
        {
            InitializeComponent();
            txtEmail.Text = "admin@fstore.com";
            txtPassword.Text = "admin@@";
            _memberRepository = new MemberRepository();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                txtEmail.Text = tmpEmail;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == String.Empty || txtEmail.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                var member = _memberRepository.GetMembers()
                    .Where(x => x.Email == txtEmail.Text && x.Password == txtPassword.Text)
                    .FirstOrDefault();

                if (member is not null)
                {
                    tmpEmail = txtEmail.Text;

                    if (member.Email.Equals("admin@fstore.com"))
                    {
                        if (tmpEmail != null)
                        {
                            frmMain frmMain = new()
                            {
                                tmpEmail = tmpEmail
                            };
                            MessageBox.Show("    Login successfully!   ");
                            this.Hide();
                            frmMain.Show();
                        }
                        else
                        {
                            frmMain frmMain = new();
                            MessageBox.Show("    Login successfully!   ");
                            this.Hide();
                            frmMain.Show();
                        }
                    }
                    else
                    {
                        if (tmpEmail != null)
                        {
                            frmUserMain frmUserMain = new()
                            {
                                tmpEmail = tmpEmail
                            };
                            MessageBox.Show("    Login successfully!   ");
                            this.Hide();
                            frmUserMain.Show();
                        }
                        else
                        {
                            frmUserMain frmUserMain = new();
                            MessageBox.Show("    Login successfully!   ");
                            this.Hide();
                            frmUserMain.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}