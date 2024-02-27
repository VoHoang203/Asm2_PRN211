using System.Windows.Forms;

namespace SalesWinApp
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMemberManagement = new System.Windows.Forms.Button();
            this.btnOrderManagement = new System.Windows.Forms.Button();
            this.btnProductManagement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(337, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMemberManagement
            // 
            this.btnMemberManagement.Location = new System.Drawing.Point(176, 122);
            this.btnMemberManagement.Name = "btnMemberManagement";
            this.btnMemberManagement.Size = new System.Drawing.Size(453, 35);
            this.btnMemberManagement.TabIndex = 1;
            this.btnMemberManagement.Text = "Member Management";
            this.btnMemberManagement.UseVisualStyleBackColor = true;
            this.btnMemberManagement.Click += new System.EventHandler(this.btnMemberManagement_Click);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Location = new System.Drawing.Point(176, 200);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(453, 35);
            this.btnProductManagement.TabIndex = 2;
            this.btnProductManagement.Text = "Product Management";
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnOrderManagement
            // 
            this.btnOrderManagement.Location = new System.Drawing.Point(176, 277);
            this.btnOrderManagement.Name = "btnOrderManagement";
            this.btnOrderManagement.Size = new System.Drawing.Size(453, 35);
            this.btnOrderManagement.TabIndex = 3;
            this.btnOrderManagement.Text = "Order Management";
            this.btnOrderManagement.UseVisualStyleBackColor = true;
            this.btnOrderManagement.Click += new System.EventHandler(this.btnOrderManagement_Click);

            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(176, 422);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(453, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(663, 45);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(107, 39);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(176, 350);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(453, 35);
            this.btnStatistics.TabIndex = 4;
            this.btnStatistics.Text = "Sales Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnProductManagement);
            this.Controls.Add(this.btnOrderManagement);
            this.Controls.Add(this.btnMemberManagement);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnMemberManagement;
        private Button btnOrderManagement;
        private Button btnProductManagement;
        private Button btnClose;
        private Button btnLogout;
        private Button btnStatistics;
    }
}