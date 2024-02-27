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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        public IOrderRepository _orderRepository;
        public IOrderDetailRepository _orderDetailRepository;

        BindingSource _source;

        public Order CurrentGrid = new();

        public string tmpEmail { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }

        public frmOrders()
        {
            InitializeComponent();
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            if (tmpEmail != null)
            {
                frmReadOrder frmReadOrder = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    typeOfOrderPage = 1,
                    tmpEmail = tmpEmail,
                    Order = CurrentGrid
                };
                this.Hide();
                frmReadOrder.Show();
            }
            else
            {
                frmReadOrder frmReadOrder = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    typeOfOrderPage = 1,
                    Order = CurrentGrid
                };
                this.Hide();
                frmReadOrder.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var comfirmationResult = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (comfirmationResult == DialogResult.Yes)
            {
                _orderDetailRepository.Delete(CurrentGrid.OrderId);
                _orderRepository.Delete(CurrentGrid.OrderId);
                MessageBox.Show("Delete successfully!");
                LoadAllOrders();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUpdateOrder frmUpdateOrder = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail,
                    Order = CurrentGrid
                };
                this.Hide();
                frmUpdateOrder.Show();
            }
            else
            {
                frmUpdateOrder frmUpdateOrder = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    Order = CurrentGrid
                };
                this.Hide();
                frmUpdateOrder.Show();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmAddOrder frmAddOrder = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail
                };
                this.Hide();
                frmAddOrder.Show();
            }
            else
            {
                frmAddOrder frmAddOrder = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn
                };

                this.Hide();
                frmAddOrder.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadAllOrders()
        {
            var allOrders = _orderRepository.GetOrders();
            try
            {
                _source = new BindingSource();
                _source.DataSource = allOrders;

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = _source;

                if (allOrders.Count() == 0)
                {
                    btnRead.Enabled = false;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnRead.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    CurrentGrid.OrderId = int.Parse(dgvOrders.Rows[0].Cells[0].Value.ToString());
                    CurrentGrid.MemberId = int.Parse(dgvOrders.Rows[0].Cells[1].Value.ToString());
                    CurrentGrid.OrderDate = DateTime.Parse(dgvOrders.Rows[0].Cells[2].Value.ToString());
                    CurrentGrid.RequiredDate = null;
                    CurrentGrid.ShippedDate = null;
                    if (dgvOrders.Rows[0].Cells[3].Value != null)
                    {
                        CurrentGrid.RequiredDate = DateTime.Parse(dgvOrders.Rows[0].Cells[3].Value.ToString());
                    }
                    if (dgvOrders.Rows[0].Cells[4].Value != null)
                    {
                        CurrentGrid.ShippedDate = DateTime.Parse(dgvOrders.Rows[0].Cells[4].Value.ToString());
                    }
                    CurrentGrid.Freight = decimal.Parse(dgvOrders.Rows[0].Cells[5].Value.ToString());
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadAllOrders();
           // dgvOrders.CurrentCell = dgvOrders.Rows[CurrentRow].Cells[CurrentColumn];
            CurrentGrid.OrderId = int.Parse(dgvOrders.Rows[CurrentRow].Cells[0].Value.ToString());
            CurrentGrid.MemberId = int.Parse(dgvOrders.Rows[CurrentRow].Cells[1].Value.ToString());
            CurrentGrid.OrderDate = DateTime.Parse(dgvOrders.Rows[CurrentRow].Cells[2].Value.ToString());
            CurrentGrid.RequiredDate = null;
            CurrentGrid.ShippedDate = null;
            if (dgvOrders.Rows[CurrentRow].Cells[3].Value != null)
            {
                CurrentGrid.RequiredDate = DateTime.Parse(dgvOrders.Rows[CurrentRow].Cells[3].Value.ToString());
            }
            if (dgvOrders.Rows[CurrentRow].Cells[4].Value != null)
            {
                CurrentGrid.ShippedDate = DateTime.Parse(dgvOrders.Rows[CurrentRow].Cells[4].Value.ToString());
            }
            CurrentGrid.Freight = decimal.Parse(dgvOrders.Rows[CurrentRow].Cells[5].Value.ToString());
        }

        private void frmOrders_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < _orderRepository.GetOrders().Count && e.RowIndex >= 0)
            {
                btnRead.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                CurrentRow = e.RowIndex;
                CurrentColumn = e.ColumnIndex;
                CurrentGrid.OrderId = int.Parse(dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString());
                CurrentGrid.MemberId = int.Parse(dgvOrders.Rows[e.RowIndex].Cells[1].Value.ToString());
                CurrentGrid.OrderDate = DateTime.Parse(dgvOrders.Rows[e.RowIndex].Cells[2].Value.ToString());
                CurrentGrid.RequiredDate = null;
                CurrentGrid.ShippedDate = null;
                if (dgvOrders.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    CurrentGrid.RequiredDate = DateTime.Parse(dgvOrders.Rows[e.RowIndex].Cells[3].Value.ToString());
                }
                if (dgvOrders.Rows[e.RowIndex].Cells[4].Value != null)
                {
                    CurrentGrid.ShippedDate = DateTime.Parse(dgvOrders.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
            }
            else
            {
                btnRead.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void dgvOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvOrders.Columns[5].Visible = false;
            this.dgvOrders.Columns[6].Visible = false;
            this.dgvOrders.Columns[7].Visible = false;
        }
    }
}