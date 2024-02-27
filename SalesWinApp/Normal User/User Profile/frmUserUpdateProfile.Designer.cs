using System.Windows.Forms;

namespace SalesWinApp.Normal_User
{
    partial class frmUserUpdateProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSubmitPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSubmitPassword
            // 
            this.txtSubmitPassword.Location = new System.Drawing.Point(206, 109);
            this.txtSubmitPassword.Name = "txtSubmitPassword";
            this.txtSubmitPassword.PasswordChar = '*';
            this.txtSubmitPassword.Size = new System.Drawing.Size(375, 27);
            this.txtSubmitPassword.TabIndex = 19;
            this.txtSubmitPassword.TextChanged += new System.EventHandler(this.txtSubmitPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Submit Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(206, 169);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(375, 27);
            this.txtCompanyName.TabIndex = 17;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Company Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(206, 289);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(375, 27);
            this.txtCountry.TabIndex = 15;
            this.txtCountry.TextChanged += new System.EventHandler(this.txtCountry_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Country";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(206, 228);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(375, 27);
            this.txtCity.TabIndex = 13;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "City";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 49);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(375, 27);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(426, 359);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 39);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.Location = new System.Drawing.Point(240, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 39);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Submit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUserUpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 438);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSubmitPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Name = "frmUserUpdateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUserUpdateProfile_FormClosing);
            this.Load += new System.EventHandler(this.frmUserUpdateProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSubmitPassword;
        private Label label5;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtCountry;
        private Label label3;
        private TextBox txtCity;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
    }
}