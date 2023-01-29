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
    public class AdminLogic : BaseContextLogic, IAdminLogic
    {
        public AdminLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertAdminItem(AdminItem adminItem)
        {
            _serviceContext.Admins.Add(adminItem);
            _serviceContext.SaveChanges();
        }
        List<AdminItem> IAdminLogic.GetAllAdmins()
        {
            return _serviceContext.Set<AdminItem>().ToList();
        }
    }
}

