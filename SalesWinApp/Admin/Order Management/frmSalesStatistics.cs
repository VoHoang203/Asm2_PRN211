using DataAccess.Models;
using DataAccess.Repository;
using SalesWinApp.Admin.Order_Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp.Admin
{
    public partial class frmSalesStatistics : Form
    {
        public IOrderRepository _orderRepository;
        public IOrderDetailRepository _orderDetailRepository;

        public bool isSearched { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        BindingSource _source;

        public Order CurrentGrid = new();

        public string tmpEmail { get; set; }

        public frmSalesStatistics()
        {
            InitializeComponent();
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
        }

        private void LoadAllOrders()
        {
            var allOrders = _orderRepository.GetOrders();
            try
            {
                _source = new BindingSource();
                _source.DataSource = allOrders;

                dgvSales.DataSource = null;
                dgvSales.DataSource = _source;

                if (allOrders.Count() == 0)
                {
                    btnRead.Enabled = false;
                }
                else
                {
                    btnRead.Enabled = true;
                    CurrentGrid.OrderId = int.Parse(dgvSales.Rows[0].Cells[0].Value.ToString());
                    CurrentGrid.MemberId = int.Parse(dgvSales.Rows[0].Cells[1].Value.ToString());
                    CurrentGrid.OrderDate = DateTime.Parse(dgvSales.Rows[0].Cells[2].Value.ToString());
                    CurrentGrid.RequiredDate = null;
                    CurrentGrid.ShippedDate = null;
                    if (dgvSales.Rows[0].Cells[3].Value != null)
                    {
                        CurrentGrid.RequiredDate = DateTime.Parse(dgvSales.Rows[0].Cells[3].Value.ToString());
                    }
                    if (dgvSales.Rows[0].Cells[4].Value != null)
                    {
                        CurrentGrid.ShippedDate = DateTime.Parse(dgvSales.Rows[0].Cells[4].Value.ToString());
                    }
                    CurrentGrid.Freight = decimal.Parse(dgvSales.Rows[0].Cells[5].Value.ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void LoadAllOrdersBySearch()
        {
            var allOrders = _orderRepository.GetOrders()
                .Where(c => DateTime.Compare(DateTime.Parse(txtStartDate.Text), c.OrderDate) <= 0
                && DateTime.Compare(DateTime.Parse(txtEndDate.Text), c.OrderDate) >= 0);
            var check = _orderRepository.GetOrders()
                .FirstOrDefault(c => DateTime.Compare(DateTime.Parse(txtStartDate.Text), c.OrderDate) <= 0
                && DateTime.Compare(DateTime.Parse(txtEndDate.Text), c.OrderDate) >= 0);
            if (DateTime.Compare(DateTime.Parse(txtStartDate.Text), DateTime.Parse(txtEndDate.Text)) <= 0)
            {
                if (check != null)
                {
                    try
                    {
                        _source = new BindingSource();
                        _source.DataSource = allOrders;

                        dgvSales.DataSource = null;
                        dgvSales.DataSource = _source;

                        if (allOrders.Count() == 0)
                        {
                            btnRead.Enabled = false;
                        }
                        else
                        {
                            btnRead.Enabled = true;
                            CurrentGrid.OrderId = int.Parse(dgvSales.Rows[0].Cells[0].Value.ToString());
                            CurrentGrid.MemberId = int.Parse(dgvSales.Rows[0].Cells[1].Value.ToString());
                            CurrentGrid.OrderDate = DateTime.Parse(dgvSales.Rows[0].Cells[2].Value.ToString());
                            CurrentGrid.RequiredDate = null;
                            CurrentGrid.ShippedDate = null;
                            if (dgvSales.Rows[0].Cells[3].Value != null)
                            {
                                CurrentGrid.RequiredDate = DateTime.Parse(dgvSales.Rows[0].Cells[3].Value.ToString());
                            }
                            if (dgvSales.Rows[0].Cells[4].Value != null)
                            {
                                CurrentGrid.ShippedDate = DateTime.Parse(dgvSales.Rows[0].Cells[4].Value.ToString());
                            }
                            CurrentGrid.Freight = decimal.Parse(dgvSales.Rows[0].Cells[5].Value.ToString());
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("No result!");
                    dgvSales.Rows.Clear();
                    dgvSales.Refresh();
                    dgvSales.DataSource = null;
                    btnRead.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("StartDate cannot be later than EndDate!");
                dgvSales.Rows.Clear();
                dgvSales.Refresh();
                dgvSales.DataSource = null;
                btnRead.Enabled = false;
            }
        }

        private void txtEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAllOrdersBySearch();
            isSearched = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmReadOrder frmReadOrder = new()
                {
                    typeOfOrderPage = 2,
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail,
                    Order = CurrentGrid,
                    StartDate = DateTime.Parse(txtStartDate.Text),
                    EndDate = DateTime.Parse(txtEndDate.Text),
                    isSearched = isSearched

                };
                this.Hide();
                frmReadOrder.Show();
            }
            else
            {
                frmReadOrder frmReadOrder = new()
                {
                    typeOfOrderPage = 2,
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    Order = CurrentGrid,
                    StartDate = DateTime.Parse(txtStartDate.Text),
                    EndDate = DateTime.Parse(txtEndDate.Text),
                    isSearched = isSearched
                };
                this.Hide();
                frmReadOrder.Show();
            }
        }

        private void frmSalesStatistics_Load(object sender, EventArgs e)
        {
            txtStartDate.Text = StartDate.ToString();
            txtEndDate.Text = EndDate.ToString();
            if (!isSearched)
            {
                LoadAllOrders();
            }
            else
            {
                LoadAllOrdersBySearch();
            }
            dgvSales.CurrentCell = dgvSales.Rows[CurrentRow].Cells[CurrentColumn];
            CurrentGrid.OrderId = int.Parse(dgvSales.Rows[CurrentRow].Cells[0].Value.ToString());
            CurrentGrid.MemberId = int.Parse(dgvSales.Rows[CurrentRow].Cells[1].Value.ToString());
            CurrentGrid.OrderDate = DateTime.Parse(dgvSales.Rows[CurrentRow].Cells[2].Value.ToString());
            CurrentGrid.RequiredDate = null;
            CurrentGrid.ShippedDate = null;
            if (dgvSales.Rows[CurrentRow].Cells[3].Value != null)
            {
                CurrentGrid.RequiredDate = DateTime.Parse(dgvSales.Rows[CurrentRow].Cells[3].Value.ToString());
            }
            if (dgvSales.Rows[CurrentRow].Cells[4].Value != null)
            {
                CurrentGrid.ShippedDate = DateTime.Parse(dgvSales.Rows[CurrentRow].Cells[4].Value.ToString());
            }
        }

        private void frmSalesStatistics_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < _orderRepository.GetOrders().Count && e.RowIndex >= 0)
            {
                btnRead.Enabled = true;
                CurrentRow = e.RowIndex;
                CurrentColumn = e.ColumnIndex;
                CurrentGrid.OrderId = int.Parse(dgvSales.Rows[e.RowIndex].Cells[0].Value.ToString());
                CurrentGrid.MemberId = int.Parse(dgvSales.Rows[e.RowIndex].Cells[1].Value.ToString());
                CurrentGrid.OrderDate = DateTime.Parse(dgvSales.Rows[e.RowIndex].Cells[2].Value.ToString());
                CurrentGrid.RequiredDate = null;
                CurrentGrid.ShippedDate = null;
                if (dgvSales.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    CurrentGrid.RequiredDate = DateTime.Parse(dgvSales.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                if (dgvSales.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    CurrentGrid.ShippedDate = DateTime.Parse(dgvSales.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            else
            {
                btnRead.Enabled = false;
            }
        }

        private void dgvSales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvSales.Columns[5].Visible = false;
            this.dgvSales.Columns[6].Visible = false;
            this.dgvSales.Columns[7].Visible = false;
        }
    }
}