using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace Comercio_Local.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderLogic _orderLogic;
        public OrderService(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
        }
        public int InsertOrder(OrderItem orderItem)
        {
            _orderLogic.InsertOrderItem(orderItem);
            return orderItem.Id;
        }
        public List<OrderItem> GetAllOrders()
        {
            return _orderLogic.GetAllOrders();
        }
        public void DeleteOrderItem(int id)
        {
            _orderLogic.DeleteOrderItem(id);
        }

        public void UpdateOrder(OrderItem orderItem)
        {
            _orderLogic.UpdateOrder(orderItem);
        }
    }
}
