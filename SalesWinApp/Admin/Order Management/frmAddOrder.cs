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

namespace SalesWinApp.Admin.Order_Management
{
    public partial class frmAddOrder : Form
    {
        private bool isAdded = false;
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }

        public IOrderRepository _orderRepository;
        public IMemberRepository _memberRepository;
        public IProductRepository _productRepository;
        public IOrderDetailRepository _orderDetailRepository;

        private bool EmailOK = false;
        private bool ProductOK = false;

        public string tmpEmail { get; set; }

        public frmAddOrder()
        {
            _orderRepository = new OrderRepository();
            _memberRepository = new MemberRepository();
            _productRepository = new ProductRepository();
            _orderDetailRepository = new OrderDetailRepository();
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isAdded)
            {
                if (tmpEmail != null)
                {
                    frmOrders frmOrders = new()
                    {
                        tmpEmail = tmpEmail
                    };
                    frmOrders.Show();
                }
                else
                {
                    frmOrders frmOrders = new();
                    frmOrders.Show();
                }
            }
            else
            {
                if (tmpEmail != null)
                {
                    frmOrders frmOrders = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn,
                        tmpEmail = tmpEmail
                    };
                    frmOrders.Show();
                }
                else
                {
                    frmOrders frmOrders = new()
                    {
                        CurrentRow = CurrentRow,
                        CurrentColumn = CurrentColumn
                    };
                    frmOrders.Show();
                }
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRequiredDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtShippedDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                if (int.TryParse(txtProductID.Text, out _))
                {
                    var tmpProduct = _productRepository.GetProducts().FirstOrDefault(c => c.ProductId == int.Parse(txtProductID.Text));
                    if (tmpProduct != null)
                    {
                        txtProductName.Text = tmpProduct.ProductName;
                        ProductOK = true;
                    }
                    else
                    {
                        txtProductName.Text = "NOT FOUND";
                        ProductOK = false;
                    }
                }
                else
                {
                    txtProductName.Text = "NOT FOUND";
                    ProductOK = false;
                }
            }
            else
            {
                txtProductName.Text = "";
                ProductOK = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            if (txtMemberID.Text != "")
            {
                if (int.TryParse(txtMemberID.Text, out _))
                {
                    var tmpMember = _memberRepository.GetMembers().FirstOrDefault(c => c.MemberId == int.Parse(txtMemberID.Text));
                    if (tmpMember != null)
                    {
                        txtMemberEmail.Text = tmpMember.Email;
                        EmailOK = true;
                    }
                    else
                    {
                        txtMemberEmail.Text = "NOT FOUND";
                        EmailOK = false;
                    }
                }
                else
                {
                    txtMemberEmail.Text = "NOT FOUND";
                    EmailOK = false;
                }
            }
            else
            {
                txtMemberEmail.Text = "";
                EmailOK = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {

        }

        private void txtOrderDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtRequiredDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtShippedDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text != "" && txtProductID.Text != "" && txtOrderDate.Text != "" && txtFreight.Text != "" && txtUnitPrice.Text != "" && txtQuantity.Text != "" && txtDiscount.Text != "")
            {
                if (EmailOK)
                {
                    if (ProductOK)
                    {
                        if (decimal.TryParse(txtFreight.Text, out _) && decimal.Parse(txtFreight.Text) >= 0)
                        {
                            if (decimal.TryParse(txtUnitPrice.Text, out _) && decimal.Parse(txtUnitPrice.Text) >= 0)
                            {
                                if (int.TryParse(txtQuantity.Text, out _) && int.Parse(txtQuantity.Text) >= 0)
                                {
                                    if (int.TryParse(txtDiscount.Text, out _) && int.Parse(txtDiscount.Text) >= 0)
                                    {
                                        Order Order = new();
                                        Order.MemberId = int.Parse(txtMemberID.Text);
                                        Order.OrderDate = DateTime.Parse(txtOrderDate.Text);
                                        Order.RequiredDate = DateTime.Parse(txtRequiredDate.Text);
                                        Order.ShippedDate = DateTime.Parse(txtShippedDate.Text);
                                        Order.Freight = decimal.Parse(txtFreight.Text);
                                        _orderRepository.Create(Order);
                                        OrderDetail OrderDetail = new();
                                        OrderDetail.OrderId = Order.OrderId;
                                        OrderDetail.ProductId = int.Parse(txtProductID.Text);
                                        OrderDetail.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                                        OrderDetail.Quantity = int.Parse(txtQuantity.Text);
                                        OrderDetail.Discount = int.Parse(txtDiscount.Text);
                                        _orderDetailRepository.Create(OrderDetail);
                                        MessageBox.Show("Create successfully!");
                                        isAdded = true;
                                        btnClose_Click(sender, e);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Invalid input format for Discount!");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Invalid input format for Quantity!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid input format for Unit Price!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input format for Freight!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found!");
                    }
                }
                else
                {
                    MessageBox.Show("Member Email not found!");
                }
            }
            else
            {
                MessageBox.Show("All fields are required!");
            }
        }
    }
}