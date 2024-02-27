using System.Windows.Forms;

namespace SalesWinApp.Admin
{
    partial class frmSalesStatistics
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
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSales
            // 
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(40, 213);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersWidth = 51;
            this.dgvSales.RowTemplate.Height = 29;
            this.dgvSales.Size = new System.Drawing.Size(729, 240);
            this.dgvSales.TabIndex = 8;
            this.dgvSales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSales_CellClick);
            this.dgvSales.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSales_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(287, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sales Statistics";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(571, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 39);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "End Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(218, 99);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(313, 27);
            this.txtStartDate.TabIndex = 13;
            this.txtStartDate.ValueChanged += new System.EventHandler(this.txtStartDate_ValueChanged);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(218, 158);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(313, 27);
            this.txtEndDate.TabIndex = 14;
            this.txtEndDate.ValueChanged += new System.EventHandler(this.txtEndDate_ValueChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(459, 490);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 39);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(218, 490);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(135, 39);
            this.btnRead.TabIndex = 16;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // frmSalesStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 562);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSales);
            this.Name = "frmSalesStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalesStatistics_FormClosing);
            this.Load += new System.EventHandler(this.frmSalesStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvSales;
        private Label label1;
        private Button btnSearch;
        private Label label2;
        private Label label3;
        private DateTimePicker txtStartDate;
        private DateTimePicker txtEndDate;
        private Button btnClose;
        private Button btnRead;
    }
}