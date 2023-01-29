using Comercio_Local.IServices;
using Entities.Entities;
using Logic.ILogic;

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
    }
}