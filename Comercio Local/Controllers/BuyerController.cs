using Comercio_Local.IServices;
using Comercio_Local.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Comercio_Local.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuyerController : ControllerBase
    {
        private readonly ILogger<BuyerController> _logger;
        private readonly IBuyerService _buyerService;
        public BuyerController(ILogger<BuyerController> logger, IBuyerService buyerService, IBuyerService buyerService)
        {
            _logger = logger;
            _buyerService = buyerService;
        }
        [HttpPost(Name = "InsertBuyer")]
        public int Post([FromBody] BuyerItem buyer)
        {
            return _buyerService.InsertBuyer(buyer);
        }
        [HttpPost(Name = "InsertBuyer")]
        public int Post([FromBody] BuyerItem buyerItem)
        {
            return _buyerService.InsertBuyer(buyerItem);
        }
    }
}
