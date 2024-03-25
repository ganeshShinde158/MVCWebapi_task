using MVCWebapi_task.Models;
namespace MVCWebapi_task.Services
{
    public class UserServices : IUserServices
    {
        SenwellDbsContext _dbContext;

        public UserServices(SenwellDbsContext dbContext)
        {
            _dbContext = dbContext;
        }
        
           
       

        public void AddUsers(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void DeleteUsers(int id)
        {
            User user = _dbContext.Users.Find(id);
            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();

        }

        public User GetUserById(int id)
        {
            return _dbContext.Users.Find(id);
        }

        public List<User> GetUsers()
        {
            return _dbContext.Users.ToList();

        }

        public void UpdateUsers(User user)
        {
            _dbContext.Users.Update(user);
        }
    }
}
