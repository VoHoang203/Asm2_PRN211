using System.Windows.Forms;

namespace SalesWinApp.Admin.Product_Management
{
    partial class frmAddProduct
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
            this.txtUnitInStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(174, 266);
            this.txtUnitInStock.MaxLength = 15;
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(251, 27);
            this.txtUnitInStock.TabIndex = 33;
            this.txtUnitInStock.TextChanged += new System.EventHandler(this.txtUnitInStock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Units In Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(174, 200);
            this.txtUnitPrice.MaxLength = 15;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(251, 27);
            this.txtUnitPrice.TabIndex = 31;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Unit Price";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(174, 134);
            this.txtWeight.MaxLength = 20;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(251, 27);
            this.txtWeight.TabIndex = 29;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Weight";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(174, 68);
            this.txtProductName.MaxLength = 40;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(251, 27);
            this.txtProductName.TabIndex = 27;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Product Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(284, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(98, 347);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 35);
            this.btnCreate.TabIndex = 34;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 436);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtUnitInStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddProduct_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUnitInStock;
        private Label label5;
        private TextBox txtUnitPrice;
        private Label label3;
        private TextBox txtWeight;
        private Label label4;
        private TextBox txtProductName;
        private Label label2;
        private Button btnClose;
        private Button btnCreate;
    }
}