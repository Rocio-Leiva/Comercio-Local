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
    public class UserLogic : BaseContextLogic, IUserLogic
    {
        public UserLogic(ServiceContext serviceContext) : base(serviceContext) { }
        public void InsertUserItem(UserItem userItem)
        {
            _serviceContext.Users.Add(userItem);
            _serviceContext.SaveChanges();
        }

        List<UserItem> IUserLogic.GetAllUsers()
        {
            return _serviceContext.Set<UserItem>().ToList();
        }
        public void DeleteUserItem(int id)
        {

            _serviceContext.Users.Remove(_serviceContext.Set<UserItem>().Where(i => i.Id == id).First());

            _serviceContext.SaveChanges();

        }
        public void UpdateUser(UserItem userItem)
        {

            _serviceContext.Users.Update(userItem);

            _serviceContext.SaveChanges();

        }

    }
}
