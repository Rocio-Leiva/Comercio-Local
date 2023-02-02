using Comercio_Local.IServices;
using Comercio_Local.Services;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Comercio_Local.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] ProductItem productItem)
        {
            return _productService.InsertProduct(productItem);
        }

        [HttpGet(Name = "GetProductItem")]
        public List<ProductItem> Get()
        {
            return _productService.GetProductItem();
        }


        [HttpDelete(Name = "DeleteProductItem")]

        public void DeleteProductItem([FromQuery] int id)
        {
            _productService.DeleteProductItem(id);
        }
        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromBody] ProductItem productItem)
        {
            _productService.UpdateProduct(productItem);
        }
    }
}