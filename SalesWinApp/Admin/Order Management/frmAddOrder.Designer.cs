using System.Windows.Forms;

namespace SalesWinApp.Admin.Order_Management
{
    partial class frmAddOrder
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
            this.btnClose = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(446, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(166, 132);
            this.txtMemberID.MaxLength = 30;
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(208, 27);
            this.txtMemberID.TabIndex = 16;
            this.txtMemberID.TextChanged += new System.EventHandler(this.txtMemberID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Member ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Location = new System.Drawing.Point(166, 181);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.ReadOnly = true;
            this.txtMemberEmail.Size = new System.Drawing.Size(208, 27);
            this.txtMemberEmail.TabIndex = 18;
            this.txtMemberEmail.TextChanged += new System.EventHandler(this.txtMemberEmail_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Member Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(166, 231);
            this.txtProductID.MaxLength = 30;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(208, 27);
            this.txtProductID.TabIndex = 20;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(166, 281);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(208, 27);
            this.txtProductName.TabIndex = 22;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Product Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(535, 253);
            this.txtUnitPrice.MaxLength = 15;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(208, 27);
            this.txtUnitPrice.TabIndex = 30;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Unit Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(535, 203);
            this.txtFreight.MaxLength = 15;
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(208, 27);
            this.txtFreight.TabIndex = 28;
            this.txtFreight.TextChanged += new System.EventHandler(this.txtFreight_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Freight";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Shipped Date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Required Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Order Date";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(535, 304);
            this.txtQuantity.MaxLength = 15;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(208, 27);
            this.txtQuantity.TabIndex = 34;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Quantity";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(535, 355);
            this.txtDiscount.MaxLength = 15;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(208, 27);
            this.txtDiscount.TabIndex = 36;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 35;
            this.label12.Text = "Discount";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(535, 54);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(208, 27);
            this.txtOrderDate.TabIndex = 37;
            this.txtOrderDate.ValueChanged += new System.EventHandler(this.txtOrderDate_ValueChanged_1);
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(535, 102);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(208, 27);
            this.txtRequiredDate.TabIndex = 38;
            this.txtRequiredDate.ValueChanged += new System.EventHandler(this.txtRequiredDate_ValueChanged_1);
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(535, 151);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(208, 27);
            this.txtShippedDate.TabIndex = 39;
            this.txtShippedDate.ValueChanged += new System.EventHandler(this.txtShippedDate_ValueChanged_1);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(239, 420);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 35);
            this.btnCreate.TabIndex = 40;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMemberEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddOrder_FormClosing);
            this.Load += new System.EventHandler(this.frmAddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private TextBox txtMemberID;
        private Label label2;
        private TextBox txtMemberEmail;
        private Label label3;
        private TextBox txtProductID;
        private Label label4;
        private TextBox txtProductName;
        private Label label5;
        private TextBox txtUnitPrice;
        private Label label6;
        private TextBox txtFreight;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtQuantity;
        private Label label11;
        private TextBox txtDiscount;
        private Label label12;
        private DateTimePicker txtOrderDate;
        private DateTimePicker txtRequiredDate;
        private DateTimePicker txtShippedDate;
        private Button btnCreate;
    }
}