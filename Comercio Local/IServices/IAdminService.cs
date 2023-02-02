using Entities.Entities;

namespace Comercio_Local.IServices
{

        public interface IAdminService
        {
            int InsertAdmin(AdminItem adminItem);
            List<AdminItem> GetAllAdmins();
            void DeleteAdminItem(int id);
            void UpdateAdmin(AdminItem adminItem);
    }
 }

