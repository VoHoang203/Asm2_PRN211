using System.Windows.Forms;

namespace SalesWinApp.Admin.Product_Management
{
    partial class frmReadProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(191, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Product ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(172, 51);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(251, 27);
            this.txtProductID.TabIndex = 16;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(172, 117);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(251, 27);
            this.txtProductName.TabIndex = 18;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(172, 249);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(251, 27);
            this.txtUnitPrice.TabIndex = 22;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Unit Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(172, 183);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(251, 27);
            this.txtWeight.TabIndex = 20;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Weight";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(172, 315);
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.ReadOnly = true;
            this.txtUnitInStock.Size = new System.Drawing.Size(251, 27);
            this.txtUnitInStock.TabIndex = 24;
            this.txtUnitInStock.TextChanged += new System.EventHandler(this.txtUnitInStock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Units In Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmReadProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 472);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReadProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReadProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmReadProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private Label label1;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtUnitPrice;
        private Label label3;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtUnitInStock;
        private Label label5;
    }
}