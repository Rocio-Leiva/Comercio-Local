using Comercio_Local.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Comercio_Local.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
    }
}