using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace Comercio_Local.Services
{
 
        public class BuyerService : IBuyerService
        {
            private readonly IBuyerLogic _buyerLogic;
            public BuyerService(IBuyerLogic BuyerLogic)
            {
                _buyerLogic = BuyerLogic;
            }
            public int InsertBuyer(BuyerItem buyerItem)
            {
                _buyerLogic.InsertBuyerItem(buyerItem);
                return buyerItem.Id;
            }
            List<BuyerItem> IBuyerService.GetAllBuyers()
            {
            return _buyerLogic.GetAllBuyers();
            }
            public void DeleteBuyerItem(int id)
            {
            _buyerLogic.DeleteBuyerItem(id);
            }

            public void UpdateBuyer(BuyerItem buyerItem)
            {
            _buyerLogic.UpdateBuyer(buyerItem);
            }
    }
    
}

