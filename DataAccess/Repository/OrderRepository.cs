using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {

        public void Create(Order order)
        {
            PRN221_Assignment02Context.Instance.Add(order);
            PRN221_Assignment02Context.Instance.SaveChanges();
        }

        public void Delete(int id)
        {
            Order order = GetOrder(id);
            PRN221_Assignment02Context.Instance.Remove(order);
            PRN221_Assignment02Context.Instance.SaveChanges();
        }

        public Order GetOrder(int id)
        {
            return PRN221_Assignment02Context.Instance.Orders.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<Order> GetOrders() => PRN221_Assignment02Context.Instance.Orders.ToList();

        public void Update()
        {
            PRN221_Assignment02Context.Instance.SaveChanges();
        }
    }
}
