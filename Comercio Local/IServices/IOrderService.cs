﻿using Entities.Entities;

namespace Comercio_Local.IServices
{
    public interface IOrderService
    {
        int InsertOrder(OrderItem orderItem);
        List<OrderItem> GetAllOrders();
        void DeleteOrderItem(int id);
        void UpdateOrder(OrderItem orderItem);
    }
}