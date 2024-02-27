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
    public partial class frmUpdateOrder : Form
    {
        public IOrderRepository _orderRepository;
        public IMemberRepository _memberRepository;
        public IProductRepository _productRepository;
        public IOrderDetailRepository _orderDetailRepository;

        private bool EmailOK = false;
        private bool ProductOK = false;

        public string tmpEmail { get; set; }
        public int CurrentRow { get; set; }
        public int CurrentColumn { get; set; }

        public Order Order { get; set; }

        public frmUpdateOrder()
        {
            InitializeComponent();
            _orderRepository = new OrderRepository();
            _memberRepository = new MemberRepository();
            _productRepository = new ProductRepository();
            _orderDetailRepository = new OrderDetailRepository();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmpEmail != null)
            {
                frmOrders frmOrders = new()
                {
                    CurrentRow = CurrentRow,
                    CurrentColumn = CurrentColumn,
                    tmpEmail = tmpEmail,
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

        private void txtRequiredDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
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

        private void txtShippedDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdateOrder_Load(object sender, EventArgs e)
        {
            var tmpOrder = _orderRepository.GetOrders().FirstOrDefault(c => c.OrderId == Order.OrderId);
            var Member = _memberRepository.GetMembers().FirstOrDefault(c => c.MemberId == Order.MemberId);
            var OrderDetail = _orderDetailRepository.GetOrderDetails().FirstOrDefault(c => c.OrderId == Order.OrderId);
            var Product = _productRepository.GetProducts().FirstOrDefault(c => c.ProductId == OrderDetail.ProductId);
            txtOrderID.Text = Order.OrderId.ToString();
            txtMemberID.Text = Order.MemberId.ToString();
            txtProductID.Text = OrderDetail.ProductId.ToString();
            txtRequiredDate.Text = Order.RequiredDate.ToString();
            txtShippedDate.Text = Order.ShippedDate.ToString();
            txtFreight.Text = tmpOrder.Freight.ToString();
            txtUnitPrice.Text = OrderDetail.UnitPrice.ToString();
            txtQuantity.Text = OrderDetail.Quantity.ToString();
            txtDiscount.Text = OrderDetail.Discount.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Order = _orderRepository.GetOrders().FirstOrDefault(c => c.OrderId == int.Parse(txtOrderID.Text));
            var OrderDetail = _orderDetailRepository.GetOrderDetails().FirstOrDefault(c => c.OrderId == int.Parse(txtOrderID.Text));
            if (Order != null && OrderDetail != null)
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
                                            Order.MemberId = int.Parse(txtMemberID.Text);
                                            Order.OrderDate = DateTime.Parse(txtOrderDate.Text);
                                            Order.RequiredDate = DateTime.Parse(txtRequiredDate.Text);
                                            Order.ShippedDate = DateTime.Parse(txtShippedDate.Text);
                                            Order.Freight = decimal.Parse(txtFreight.Text);
                                            _orderRepository.Update();
                                            OrderDetail.ProductId = int.Parse(txtProductID.Text);
                                            OrderDetail.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                                            OrderDetail.Quantity = int.Parse(txtQuantity.Text);
                                            OrderDetail.Discount = int.Parse(txtDiscount.Text);
                                            _orderDetailRepository.Update();
                                            MessageBox.Show("Update successfully!");
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMemberEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtOrderDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtRequiredDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtShippedDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void txtFreight_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void txtMemberEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}