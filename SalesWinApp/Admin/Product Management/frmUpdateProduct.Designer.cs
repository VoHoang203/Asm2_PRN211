using System.Windows.Forms;

namespace SalesWinApp.Admin.Product_Management
{
    partial class frmUpdateProduct
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
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnitInStock
            // 
            this.txtUnitInStock.Location = new System.Drawing.Point(172, 315);
            this.txtUnitInStock.MaxLength = 15;
            this.txtUnitInStock.Name = "txtUnitInStock";
            this.txtUnitInStock.Size = new System.Drawing.Size(251, 27);
            this.txtUnitInStock.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Units In Stock";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(172, 249);
            this.txtUnitPrice.MaxLength = 15;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(251, 27);
            this.txtUnitPrice.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Unit Price";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(172, 183);
            this.txtWeight.MaxLength = 20;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(251, 27);
            this.txtWeight.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Weight";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(172, 117);
            this.txtProductName.MaxLength = 40;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(251, 27);
            this.txtProductName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Product Name";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(172, 51);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(251, 27);
            this.txtProductID.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Product ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(281, 394);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(101, 394);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 472);
            this.Controls.Add(this.btnUpdate);
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
            this.Name = "frmUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateProduct";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUpdateProduct_FormClosing);
            this.Load += new System.EventHandler(this.frmUpdateProduct_Load);
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
        private TextBox txtProductID;
        private Label label1;
        private Button btnClose;
        private Button btnUpdate;
    }
}