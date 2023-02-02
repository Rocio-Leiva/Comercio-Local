using Entities.Entities;

namespace Comercio_Local.IServices
{

    public interface IBuyerService
    {
        int InsertBuyer(BuyerItem buyerItem);
        List<BuyerItem> GetAllBuyers();
        void DeleteBuyerItem(int id);
        void UpdateBuyer(BuyerItem buyerItem);
    }
}
