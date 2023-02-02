using Comercio_Local.IServices;
using Comercio_Local.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Comercio_Local.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BuyerController : ControllerBase
    {
        private readonly ILogger<BuyerController> _logger;
        private readonly IBuyerService _buyerService;
        public BuyerController(ILogger<BuyerController> logger, IBuyerService buyerService)
        {
            _logger = logger;
            _buyerService = buyerService;
        }
        [HttpPost(Name = "InsertBuyer")]
        public int Post([FromBody] BuyerItem buyerItem)
        {
            return _buyerService.InsertBuyer(buyerItem);
        }

        [HttpGet(Name = "GetAllBuyers")]

        public List<BuyerItem> GetAllBuyers()
        {
            return _buyerService.GetAllBuyers();
        }

        [HttpDelete(Name = "DeleteBuyerItem")]
        public void DeleteBuyerItem([FromQuery] int id)
        {
            _buyerService.DeleteBuyerItem(id);
        }

        [HttpPatch(Name = "ModifyBuyer")]
        public void Patch([FromBody] BuyerItem buyerItem)
        {
             _buyerService.UpdateBuyer(buyerItem);
        }
    
    }
}

