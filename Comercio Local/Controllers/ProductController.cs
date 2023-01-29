using Comercio_Local.IServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Comercio_Local.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpPost(Name = "GetProductItem")]
        public List<ProductItem> Get()
        {
            return _productService.GetProductItem();
        }

    }
}