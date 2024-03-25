using MVCWebapi_task.Models;
namespace MVCWebapi_task.Services
{
    public interface IUserServices
    {
        List<User> GetUsers();
        User GetUserById(int id);

        void AddUsers(User user);

        void UpdateUsers(User user);

        void DeleteUsers(int id);

    }
}
