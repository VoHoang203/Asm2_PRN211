﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetails();

        void Update();

        void Create(OrderDetail orderDetail);

        void Delete(int id);

        OrderDetail GetOrderDetail(int id);
    }
}
