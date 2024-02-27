using DataAccess.Models;
using DataAccess.Repository;
using SalesWinApp.Admin.Product_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProducts : Form
    {
        public IProductRepository _productRepository;
        public IOrderDetailRepository _orderDetailRepository;

        BindingSource _source;

        public Product CurrentGrid = new();
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public int searchCategory { get; set; }
        public string searchValue { get; set; }
        public bool NeedRefresh { get; set; }
        public string submitSearch { get; set; }

        public string tmpEmail { get; set; }

        public frmProducts()
        {
            _productRepository = new ProductRepository();
            _orderDetailRepository = new OrderDetailRepository();
            InitializeComponent();

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmReadProduct frmReadProduct = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchCategory = txtSearchCatagory.SelectedIndex,
                    searchValue = submitSearch,
                    Product = CurrentGrid,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmReadProduct.Show();
            }
            else
            {
                frmReadProduct frmReadProduct = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchCategory = txtSearchCatagory.SelectedIndex,
                    searchValue = submitSearch,
                    Product = CurrentGrid
                };
                this.Hide();
                frmReadProduct.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var check = _orderDetailRepository.GetOrderDetails().FirstOrDefault(c => c.ProductId == CurrentGrid.ProductId);
            if (check == null)
            {
                _productRepository.Delete(CurrentGrid.ProductId);
                MessageBox.Show("Delete successfully!");
                btnSearch_Click(sender, e);
            }
            else
            {
                MessageBox.Show("This product cannot be deleted because there is an Order that involves it!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUpdateProduct frmUpdateProduct = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchCategory = txtSearchCatagory.SelectedIndex,
                    searchValue = submitSearch,
                    Product = CurrentGrid,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmUpdateProduct.Show();
            }
            else
            {
                frmUpdateProduct frmUpdateProduct = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchCategory = txtSearchCatagory.SelectedIndex,
                    searchValue = submitSearch,
                    Product = CurrentGrid
                };
                this.Hide();
                frmUpdateProduct.Show();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmAddProduct frmAddProduct = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchCategory = txtSearchCatagory.SelectedIndex,
                    searchValue = submitSearch,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmAddProduct.Show();
            }
            else
            {
                frmAddProduct frmAddProduct = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    searchValue = submitSearch,
                    searchCategory = txtSearchCatagory.SelectedIndex
                };
                this.Hide();
                frmAddProduct.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            if (!NeedRefresh)
            {
                txtSearch.Text = searchValue;
                txtSearchCatagory.SelectedIndex = searchCategory;
                Search();
                //dgvProducts.CurrentCell = dgvProducts.Rows[CurrentRow].Cells[CurrentColumn];
                CurrentGrid.ProductId = int.Parse(dgvProducts.Rows[CurrentRow].Cells[0].Value.ToString());
                CurrentGrid.CategoryId = int.Parse(dgvProducts.Rows[CurrentRow].Cells[1].Value.ToString());
                CurrentGrid.ProductName = dgvProducts.Rows[CurrentRow].Cells[2].Value.ToString();
                CurrentGrid.Weight = dgvProducts.Rows[CurrentRow].Cells[3].Value.ToString();
                CurrentGrid.UnitPrice = int.Parse(dgvProducts.Rows[CurrentRow].Cells[4].Value.ToString());
                CurrentGrid.UnitsInStock = int.Parse(dgvProducts.Rows[CurrentRow].Cells[5].Value.ToString());
            }
            else
            {
                txtSearch.Text = "";
                txtSearchCatagory.SelectedIndex = 0;
                LoadAllProducts();
                MessageBox.Show("The list needs reloading after the change!");
            }
        }

        private void LoadAllProducts()
        {
            var allProducts = _productRepository.GetProducts();
            try
            {
                _source = new BindingSource();
                _source.DataSource = allProducts;

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = _source;

                if (allProducts.Count() == 0)
                {
                    btnRead.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnRead.Enabled = true;
                    btnCreate.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    CurrentGrid.ProductId = int.Parse(dgvProducts.Rows[0].Cells[0].Value.ToString());
                    CurrentGrid.ProductName = dgvProducts.Rows[0].Cells[1].Value.ToString();
                    CurrentGrid.Weight = dgvProducts.Rows[0].Cells[2].Value.ToString();
                    CurrentGrid.UnitPrice = decimal.Parse(dgvProducts.Rows[0].Cells[3].Value.ToString());
                    CurrentGrid.UnitsInStock = int.Parse(dgvProducts.Rows[0].Cells[4].Value.ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadAllProductsSearchByID()
        {
            var allProducts = _productRepository.GetProducts().Where(c => c.ProductId.ToString().Contains(submitSearch.Trim()));
            var check = _productRepository.GetProducts().FirstOrDefault(c => c.ProductId.ToString().Contains(submitSearch.Trim()));
            if (check != null)
            {
                try
                {
                    _source = new BindingSource();
                    _source.DataSource = allProducts;

                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = _source;

                    if (allProducts.Count() == 0)
                    {
                        btnRead.Enabled = false;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        btnRead.Enabled = true;
                        btnCreate.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        CurrentGrid.ProductId = int.Parse(dgvProducts.Rows[0].Cells[0].Value.ToString());
                        CurrentGrid.ProductName = dgvProducts.Rows[0].Cells[1].Value.ToString();
                        CurrentGrid.Weight = dgvProducts.Rows[0].Cells[2].Value.ToString();
                        CurrentGrid.UnitPrice = decimal.Parse(dgvProducts.Rows[0].Cells[3].Value.ToString());
                        CurrentGrid.UnitsInStock = int.Parse(dgvProducts.Rows[0].Cells[4].Value.ToString());
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("No result!");
                dgvProducts.Rows.Clear();
                dgvProducts.Refresh();
                dgvProducts.DataSource = null;
                btnRead.Enabled = false;
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void LoadAllProductsSearchByName()
        {
            var allProducts = _productRepository.GetProducts().Where(c => c.ProductName.ToLower().Trim().Contains(submitSearch.ToLower().Trim()));
            var check = _productRepository.GetProducts().FirstOrDefault(c => c.ProductName.ToLower().Trim().Contains(submitSearch.ToLower().Trim()));

            if (check != null)
            {
                try
                {
                    _source = new BindingSource();
                    _source.DataSource = allProducts;

                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = _source;

                    if (allProducts.Count() == 0)
                    {
                        btnRead.Enabled = false;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        btnRead.Enabled = true;
                        btnCreate.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        CurrentGrid.ProductId = int.Parse(dgvProducts.Rows[0].Cells[0].Value.ToString());
                        CurrentGrid.ProductName = dgvProducts.Rows[0].Cells[1].Value.ToString();
                        CurrentGrid.Weight = dgvProducts.Rows[0].Cells[2].Value.ToString();
                        CurrentGrid.UnitPrice = decimal.Parse(dgvProducts.Rows[0].Cells[3].Value.ToString());
                        CurrentGrid.UnitsInStock = int.Parse(dgvProducts.Rows[0].Cells[4].Value.ToString());
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("No result!");
                dgvProducts.Rows.Clear();
                dgvProducts.Refresh();
                dgvProducts.DataSource = null;
                btnRead.Enabled = false;
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
        private void LoadAllProductsSearchByUnitPrice()
        {
            var allProducts = _productRepository.GetProducts().Where(c => c.UnitPrice.ToString().Contains(submitSearch));
            var check = _productRepository.GetProducts().FirstOrDefault(c => c.UnitPrice.ToString().Contains(submitSearch));
            if (check != null)
            {
                try
                {
                    _source = new BindingSource();
                    _source.DataSource = allProducts;

                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = _source;

                    if (allProducts.Count() == 0)
                    {
                        btnRead.Enabled = false;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        btnRead.Enabled = true;
                        btnCreate.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        CurrentGrid.ProductId = int.Parse(dgvProducts.Rows[0].Cells[0].Value.ToString());
                        CurrentGrid.ProductName = dgvProducts.Rows[0].Cells[1].Value.ToString();
                        CurrentGrid.Weight = dgvProducts.Rows[0].Cells[2].Value.ToString();
                        CurrentGrid.UnitPrice = decimal.Parse(dgvProducts.Rows[0].Cells[3].Value.ToString());
                        CurrentGrid.UnitsInStock = int.Parse(dgvProducts.Rows[0].Cells[4].Value.ToString());
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("No result!");
                dgvProducts.Rows.Clear();
                dgvProducts.Refresh();
                dgvProducts.DataSource = null;
                btnRead.Enabled = false;
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }
        private void LoadAllProductsSearchByUnitsInStock()
        {
            var allProducts = _productRepository.GetProducts().Where(c => c.UnitsInStock.ToString().Contains(submitSearch));
            var check = _productRepository.GetProducts().FirstOrDefault(c => c.UnitsInStock.ToString().Contains(submitSearch));

            if (check != null)
            {
                try
                {
                    _source = new BindingSource();
                    _source.DataSource = allProducts;

                    dgvProducts.DataSource = null;
                    dgvProducts.DataSource = _source;

                    if (allProducts.Count() == 0)
                    {
                        btnRead.Enabled = false;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    else
                    {
                        btnRead.Enabled = true;
                        btnCreate.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        CurrentGrid.ProductId = int.Parse(dgvProducts.Rows[0].Cells[0].Value.ToString());
                        CurrentGrid.ProductName = dgvProducts.Rows[0].Cells[1].Value.ToString();
                        CurrentGrid.Weight = dgvProducts.Rows[0].Cells[2].Value.ToString();
                        CurrentGrid.UnitPrice = decimal.Parse(dgvProducts.Rows[0].Cells[3].Value.ToString());
                        CurrentGrid.UnitsInStock = int.Parse(dgvProducts.Rows[0].Cells[4].Value.ToString());
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("No result!");
                dgvProducts.Rows.Clear();
                dgvProducts.Refresh();
                dgvProducts.DataSource = null;
                btnRead.Enabled = false;
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search()
        {
            submitSearch = txtSearch.Text;
            if (txtSearchCatagory.Text == "By ID")
            {
                LoadAllProductsSearchByID();
            }
            else if (txtSearchCatagory.Text == "By Name")
            {
                LoadAllProductsSearchByName();
            }
            else if (txtSearchCatagory.Text == "By UnitPrice")
            {
                LoadAllProductsSearchByUnitPrice();
            }
            else if (txtSearchCatagory.Text == "By UnitsInStock")
            {
                LoadAllProductsSearchByUnitsInStock();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
            CurrentRow = 0;
            CurrentColumn = 0;
        }

        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmMain frmMain = new()
                {
                    tmpEmail = tmpEmail
                };
                frmMain.Show();
            }
            else
            {
                frmMain frmMain = new();
                frmMain.Show();
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < _productRepository.GetProducts().Count && e.RowIndex >= 0)
            {
                btnRead.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnCreate.Enabled = true;
                CurrentRow = e.RowIndex;
                CurrentColumn = e.ColumnIndex;
                CurrentGrid.ProductId = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                CurrentGrid.ProductName = dgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                CurrentGrid.Weight = dgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                //CurrentGrid.UnitPrice = decimal.Parse(dgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString());
                CurrentGrid.UnitsInStock = int.Parse(dgvProducts.Rows[e.RowIndex].Cells[4].Value.ToString());

            }
            else
            {
                btnRead.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvProducts.Columns[5].Visible = false;
        }
    }
}