using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class OrderLogic : BaseContextLogic, IOrderLogic
    {
        public OrderLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertOrderItem(OrderItem orderItem)
        {
            _serviceContext.Orders.Add(orderItem);
            _serviceContext.SaveChanges();
        }
        List<OrderItem> IOrderLogic.GetAllOrders()
        {
            return _serviceContext.Set<OrderItem>().ToList();
        }
        public void DeleteOrderItem(int id)
        {

            _serviceContext.Orders.Remove(_serviceContext.Set<OrderItem>().Where(i => i.Id == id).First());

            _serviceContext.SaveChanges();

        }
        public void UpdateOrder(OrderItem orderItem)
        {

            _serviceContext.Orders.Update(orderItem);

            _serviceContext.SaveChanges();

        }
    }
}
