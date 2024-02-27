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
    public partial class frmUpdateProduct : Form
    {
        public Product Product { get; set; }

        public IProductRepository _productRepository;

        public string tmpEmail { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public int searchCategory { get; set; }
        public string searchValue { get; set; }
        public bool NeedRefresh = false;

        public frmUpdateProduct()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmProducts frmProducts = new()
                {
                    NeedRefresh = NeedRefresh,
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchCategory = searchCategory,
                    searchValue = searchValue,
                    tmpEmail = tmpEmail
                };
                frmProducts.Show();
            }
            else
            {
                frmProducts frmProducts = new()
                {
                    NeedRefresh = NeedRefresh,
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchValue = searchValue,
                    searchCategory = searchCategory
                };
                frmProducts.Show();
            }
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            txtProductID.Text = Product.ProductId.ToString();
            txtProductName.Text = Product.ProductName;
            txtWeight.Text = Product.Weight;
            txtUnitPrice.Text = Product.UnitPrice.ToString();
            txtUnitInStock.Text = Product.UnitsInStock.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var checkName = _productRepository.GetProducts()
                .Where(c => c.ProductName.Trim().ToLower().Equals(txtProductName.Text.Trim().ToLower()))
                .SingleOrDefault();
            var updateProduct = _productRepository.GetProducts().SingleOrDefault(c => c.ProductId == Product.ProductId);
            if (updateProduct != null)
            {
                if (txtProductName.Text != "" && txtWeight.Text != "" && txtUnitPrice.Text != "" && txtUnitInStock.Text != "")
                {
                    if (checkName == null || checkName.ProductName == Product.ProductName)
                    {
                        if (!txtProductName.Text.ToLower().Trim().Contains(searchValue.ToLower().Trim()) && searchCategory == 1)
                        {
                            NeedRefresh = true;
                        }
                        if (double.TryParse(txtWeight.Text, out _) && double.Parse(txtWeight.Text) >= 0)
                        {
                            if (decimal.TryParse(txtUnitPrice.Text, out _) && decimal.Parse(txtUnitPrice.Text) >= 0)
                            {
                                if (!txtUnitPrice.ToString().Contains(searchValue.Trim()) && searchCategory == 2)
                                {
                                    NeedRefresh = true;
                                }
                                if (int.TryParse(txtUnitInStock.Text, out _) && int.Parse(txtUnitInStock.Text) >= 0)
                                {
                                    if (!txtUnitInStock.ToString().Contains(searchValue.Trim()) && searchCategory == 3)
                                    {
                                        NeedRefresh = true;
                                    }
                                    updateProduct.ProductName = txtProductName.Text;
                                    updateProduct.Weight = txtWeight.Text;
                                    updateProduct.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                                    updateProduct.UnitsInStock = int.Parse(txtUnitInStock.Text);
                                    _productRepository.Update();
                                    MessageBox.Show("Update successfully!");
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
}