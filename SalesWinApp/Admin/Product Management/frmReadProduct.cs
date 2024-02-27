using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin.Product_Management
{
    public partial class frmReadProduct : Form
    {
        public Product Product { get; set; }

        public string tmpEmail { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public int searchCategory { get; set; }
        public string searchValue { get; set; }

        public frmReadProduct()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReadProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmProducts frmProducts = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchValue = searchValue,
                    searchCategory = searchCategory,
                    tmpEmail = tmpEmail
                };
                frmProducts.Show();
            }
            else
            {
                frmProducts frmProducts = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchValue = searchValue,
                    searchCategory = searchCategory
                };
                frmProducts.Show();
            }
        }

        private void frmReadProduct_Load(object sender, EventArgs e)
        {
            txtProductID.Text = Product.ProductId.ToString();
            txtProductName.Text = Product.ProductName;
            txtWeight.Text = Product.Weight;
            txtUnitPrice.Text = Product.UnitPrice.ToString();
            txtUnitInStock.Text = Product.UnitsInStock.ToString();
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitInStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}