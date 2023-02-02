using Data;
using Entities.Entities;
using Logic.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class ProductLogic : BaseContextLogic, IProductLogic
    {
        public ProductLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertProductItem(ProductItem productItem)
        {
            _serviceContext.Products.Add(productItem);
            _serviceContext.SaveChanges();
        }

        public List<ProductItem> GetProductItem()
        {
            return _serviceContext.Set<ProductItem>().ToList();

        }

     public void DeleteProductItem(int id)
        {
         
            _serviceContext.Products.Remove(_serviceContext.Set<ProductItem>().Where(i => i.Id == id).First());

            _serviceContext.SaveChanges();

        }
     public void UpdateProduct(ProductItem productItem)
        {

            _serviceContext.Products.Update(productItem);

            _serviceContext.SaveChanges();

        }

    }
}