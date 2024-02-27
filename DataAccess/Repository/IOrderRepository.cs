using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();

        void Update();

        void Create(Order order);

        void Delete(int id);

        Order GetOrder(int id);
    }
}
