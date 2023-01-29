using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;

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
    }
}
