using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace Comercio_Local.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductLogic _productLogic;
        public ProductService(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }
        public int InsertProduct(ProductItem productItem)
        {
            _productLogic.InsertProductItem(productItem);
            return productItem.Id;
        }

         public List<ProductItem> GetProductItem() 
         {
            //var resultList = _productLogic.GetProductItem();
            // return resultList;

            return _productLogic.GetProductItem();

        }

    }
}

