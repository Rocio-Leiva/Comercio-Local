using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

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
          return _productLogic.GetProductItem();

        }

       public void DeleteProductItem(int id)
        {
            _productLogic.DeleteProductItem(id);
        }
        public void UpdateProduct(ProductItem productItem)
        {
            _productLogic.UpdateProduct(productItem);
        }
    }
}

