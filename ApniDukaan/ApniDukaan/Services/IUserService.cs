using ApniDukaan.Models;

namespace ApniDukaan.Services
{
    public interface IUserService
    {
        List<User> GetUsers();
        User GetUser(int id);
        bool Insert(User user);
        bool Update(User user);
        bool Delete(int id);
    }
}
