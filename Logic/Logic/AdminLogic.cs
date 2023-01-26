using Data;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    internal class AdminLogic
    {
        public AdminLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertAdminItem(AdminItem adminItem)
        {
            _serviceContext.Users.Add(adminItem);
            _serviceContext.SaveChanges();
        }
    }
}
