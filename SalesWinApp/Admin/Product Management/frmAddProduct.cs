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

namespace SalesWinApp.Admin.Product_Management
{
    public partial class frmAddProduct : Form
    {
        private bool isAdded = false;

        public IProductRepository _productRepository;

        public string tmpEmail { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public int searchCategory { get; set; }
        public string searchValue { get; set; }

        public frmAddProduct()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAdded)
            {
                if (tmpEmail != null)
                {
                    frmProducts frmProducts = new()
                    {
                        tmpEmail = tmpEmail
                    };
                    frmProducts.Show();
                }
                else
                {
                    frmProducts frmProducts = new();
                    frmProducts.Show();
                }
            }
            else
            {
                if (tmpEmail != null)
                {
                    frmProducts frmProducts = new()
                    {
                        tmpEmail = tmpEmail,
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn,
                        searchCategory = searchCategory,
                        searchValue = searchValue
                    };
                    frmProducts.Show();
                }
                else
                {
                    frmProducts frmProducts = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn,
                        searchCategory = searchCategory,
                        searchValue = searchValue
                    };
                    frmProducts.Show();
                }
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
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

        private void txtUnitInStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var checkName = _productRepository.GetProducts()
                .Where(c => c.ProductName.Trim().ToLower().Equals(txtProductName.Text.Trim().ToLower()))
                .SingleOrDefault();
            if (txtProductName.Text != "" && txtWeight.Text != "" && txtUnitPrice.Text != "" && txtUnitInStock.Text != "")
            {
                if (checkName == null)
                {
                    if (double.TryParse(txtWeight.Text, out _) && double.Parse(txtWeight.Text) >= 0)
                    {
                        if (decimal.TryParse(txtUnitPrice.Text, out _) && decimal.Parse(txtUnitPrice.Text) >= 0)
                        {
                            if (int.TryParse(txtUnitInStock.Text, out _) && int.Parse(txtUnitInStock.Text) >= 0)
                            {
                                Product Product = new();
                                Product.ProductName = txtProductName.Text;
                                Product.Weight = txtWeight.Text;
                                Product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                                Product.UnitsInStock = int.Parse(txtUnitInStock.Text);
                                _productRepository.Create(Product);
                                MessageBox.Show("Create successfully!");
                                isAdded = true;
                                btnClose_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Invalid input for Units In Stock!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input for Unit Price!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input for Weight!");
                    }
                }
                else
                {
                    MessageBox.Show("Duplicated Name!");
                }
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
        }
    }
}