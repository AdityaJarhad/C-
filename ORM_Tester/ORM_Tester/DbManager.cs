using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Tester
{
    internal class DbManager:IDbManager
    {
        public List<Users> getUsers()
        {
            using (var context = new CollectionContext())
            {
                var users = from Users in context.user
                            select Users;
                return users.ToList<Users>();
            }
        }
        public Users getByid(int id)
        {
            
            return null;
        }
        public bool insert(Users user)
        {
            using (var context = new CollectionContext())
            {
                context.user.Add(user);
                context.SaveChanges();
            }
            return true;
        }
        public bool update(Users user)
        {
            using (var context = new CollectionContext()) 
            {
                var u = context.user.Find(user.id);
                u.email = user.email;
                u.password = user.password;
                context.SaveChanges();
            }
            return false;
        }
        public bool delete(int id)
        {
            using (var context = new CollectionContext())
            {
                context.user.Remove(context.user.Find(id));
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
