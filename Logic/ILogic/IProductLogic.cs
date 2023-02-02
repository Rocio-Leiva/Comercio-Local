using Data;
using Entities.Entities;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IProductLogic
    {
        void InsertProductItem(ProductItem productItem);
        List<ProductItem>GetProductItem();
        void DeleteProductItem(int id);
        void UpdateProduct(ProductItem productItem);


    }
}
    
    
 
