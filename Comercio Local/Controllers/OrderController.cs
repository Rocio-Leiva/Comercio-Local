using Comercio_Local.IServices;
using Comercio_Local.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Comercio_Local.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IOrderService _orderService;
        public OrderController(ILogger<ProductController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpPost(Name = "InsertOrder")]
        public int Post([FromBody] OrderItem orderItem)
        {
            return _orderService.InsertOrder(orderItem);
        }
        
        [HttpGet(Name = "GetAllOrders")]

        public List<OrderItem> GetAllOrders()
        {
            return _orderService.GetAllOrders();
        }
        
        [HttpDelete(Name = "DeleteOrderItem")]
        public void DeleteOrderItem([FromQuery] int id)
        {
            _orderService.DeleteOrderItem(id);
        }

        [HttpPatch(Name = "ModifyOrder")]
        public void Patch([FromBody] OrderItem orderItem)
        {
            _orderService.UpdateOrder(orderItem);
        }

    }
}