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
    public interface ProductLogic 
    {
        void InsertProductItem(ProductItem productItem);
        List<ProductItem> GetProductItem();
       
    }
}
