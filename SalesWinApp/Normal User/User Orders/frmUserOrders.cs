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

namespace SalesWinApp.Normal_User
{
    public partial class frmUserOrders : Form
    {
        public IMemberRepository _memberRepository { get; set; }
        public IOrderRepository _orderRepository;
        public IOrderDetailRepository _orderDetailRepository;
        private bool isNull = true;

        BindingSource _source;

        public Order CurrentGrid = new();

        public string tmpEmail { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }

        public frmUserOrders()
        {
            _memberRepository = new MemberRepository();
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUserOrders_Load(object sender, EventArgs e)
        {
            LoadAllOrders();
            if (!isNull)
            {
                dgvOrders.CurrentCell = dgvOrders.Rows[CurrentRow].Cells[CurrentColumn];
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
            else
            {
                MessageBox.Show("You don't have any Orders!");
                btnClose_Click(sender, e);
            }
        }

        private void LoadAllOrders()
        {
            var member = _memberRepository.GetMembers().FirstOrDefault(c => c.Email == tmpEmail);
            var allOrders = _orderRepository.GetOrders().Where(c => c.MemberId == member.MemberId);
            try
            {
                _source = new BindingSource();
                _source.DataSource = allOrders;

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = _source;

                if (allOrders.Count() == 0)
                {
                    btnRead.Enabled = false;
                }
                else
                {
                    isNull = false;
                    btnRead.Enabled = true;
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

        private void frmUserOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmUserMain frmUserMain = new()
                {
                    tmpEmail = tmpEmail
                };
                frmUserMain.Show();
            }
            else
            {
                frmUserMain frmUserMain = new();
                frmUserMain.Show();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (tmpEmail != null)
            {
                frmReadOrder frmReadOrder = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    typeOfOrderPage = 3,
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
                    typeOfOrderPage = 3,
                    Order = CurrentGrid
                };
                this.Hide();
                frmReadOrder.Show();
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < _orderRepository.GetOrders().Count && e.RowIndex >= 0)
            {
                btnRead.Enabled = true;
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