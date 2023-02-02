using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IOrderLogic
    {
        void InsertOrderItem(OrderItem orderItem);
        List<OrderItem> GetAllOrders();
        void DeleteOrderItem(int id);
        void UpdateOrder(OrderItem orderItem);

    }
}