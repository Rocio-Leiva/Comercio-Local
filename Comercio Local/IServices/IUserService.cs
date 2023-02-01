using Entities.Entities;

namespace Comercio_Local.IServices
{
    public interface IUserService
    {
        int InsertUser(UserItem userItem);
        List<UserItem> GetAllUsers();
        void DeleteUserItem(int id);
        void UpdateUser(UserItem userItem);
    }

}
