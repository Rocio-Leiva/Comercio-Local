using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;

namespace Comercio_Local.Services
{
    public class AdminService
    {
        public class AdminService : IAdminService
        {
            private readonly IAdminLogic _adminLogic;
            public AdminService(IAdminLogic AdminLogic)
            {
                _adminLogic = adminLogic;
            }
            public int InsertAdmin(AdminItem adminItem)
            {
                _adminLogic.InsertAdminItem(adminItem);
                return adminItem.Id;
            }
        }
    }
}
