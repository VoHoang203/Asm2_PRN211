using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {

        public void Create(OrderDetail orderDetail)
        {
            PRN221_Assignment02Context.Instance.Add(orderDetail);
            PRN221_Assignment02Context.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            OrderDetail orderDetail = GetOrderDetail(id);
            PRN221_Assignment02Context.Instance.Remove(orderDetail);
            PRN221_Assignment02Context.Instance.SaveChanges();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return PRN221_Assignment02Context.Instance.OrderDetails.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<OrderDetail> GetOrderDetails() => PRN221_Assignment02Context.Instance.OrderDetails.ToList();

        public void Update()
        {
            PRN221_Assignment02Context.Instance.SaveChanges();
        }
    }
}
