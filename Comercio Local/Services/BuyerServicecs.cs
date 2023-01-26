using Comercio_Local.IServices;
using Entities.Entities;

namespace Comercio_Local.Services
{
    public class BuyerServicecs
    {
        public class BuyerService : IBuyerService
        {
            private readonly IBuyerLogic _buyerLogic;
            public BuyerService(IBuyerLogic AdminLogic)
            {
                _buyerLogic = buyerLogic;
            }
            public int InsertBuyer(BuyerItem buyerItem)
            {
                _buyerLogic.InsertBuyerItem(buyerItem);
                return buyerItem.Id;
            }
        }
    }
}
