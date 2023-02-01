using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;
using Logic.Logic;

namespace Comercio_Local.Services
{
    public class UserService : IUserService
    {
        private readonly IUserLogic _userLogic;
        public UserService(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }
        public int InsertUser(UserItem userItem)
        {
            _userLogic.InsertUserItem(userItem);
            return userItem.Id;
        }
        public List<UserItem> GetAllUsers()
        {
            return _userLogic.GetAllUsers();
        }
       public void DeleteUserItem(int id)
        {
            _userLogic.DeleteUserItem(id);
        }

        public void UpdateUser(UserItem userItem)
        {
            _userLogic.UpdateUser(userItem);
        }
    }
}