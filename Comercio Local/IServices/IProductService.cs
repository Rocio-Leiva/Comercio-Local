using Entities.Entities;

namespace Comercio_Local.IServices
{
    public interface IProductService
    {
       int InsertProduct(ProductItem productItem);
       List<ProductItem> GetProductItem();
       void DeleteProductItem(int id);
       void UpdateProduct(ProductItem productItem);
    }
}

