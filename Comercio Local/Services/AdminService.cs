using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace Comercio_Local.Services
{

        public class AdminService : IAdminService
        {
            private readonly IAdminLogic _adminLogic;
            public AdminService(IAdminLogic adminLogic)
            {
                _adminLogic = adminLogic;
            }
            public int InsertAdmin(AdminItem adminItem)
            {
                _adminLogic.InsertAdminItem(adminItem);
                return adminItem.Id;
            }
            public List<AdminItem> GetAllAdmins()
            {
             return _adminLogic.GetAllAdmins();
            }

             public void DeleteAdminItem(int id)
             {
                  _adminLogic.DeleteAdminItem(id);
             }

             public void UpdateAdmin(AdminItem adminItem)
             {
                 _adminLogic.UpdateAdmin(adminItem);
             }
    }
    
}


