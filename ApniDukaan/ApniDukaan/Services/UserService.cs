using ApniDukaan.Models;

namespace ApniDukaan.Services
{
    public class UserService : IUserService
    {
        public UserService() { }

        public List<User> GetUsers() 
        {
            return new List<User>(); 
        }

        public User GetUser(int id)
        {
            User user = null;
            return user;
        }
        public bool Insert(User user)
        {
            return true;
        }
        public bool Update(User user)
        {
            return true;
        }
        public bool Delete(int id)
        {
            return true;
        }
    }
}
