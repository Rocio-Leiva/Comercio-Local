using Data;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class BuyerLogic : BaseContextLogic, IBuyerLogic
    {
        public BuyerLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertBuyerItem(BuyerItem buyerItem)
        {
            _serviceContext.Buyers.Add(buyerItem);
            _serviceContext.SaveChanges();
        }
        public List<BuyerItem> GetAllBuyers()
        {
            return _serviceContext.Set<BuyerItem>().ToList();
        }
        public void DeleteBuyerItem(int id)
        {

            _serviceContext.Buyers.Remove(_serviceContext.Set<BuyerItem>().Where(i => i.Id == id).First());

            _serviceContext.SaveChanges();

        }
        public void UpdateBuyer(BuyerItem buyerItem)
        {

            _serviceContext.Buyers.Update(buyerItem);

            _serviceContext.SaveChanges();

        }
    }
}

