using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Tester
{
    internal interface IDbManager
    {
        List<Users> getUsers();
        Users getByid(int id);
        bool insert(Users user);
        bool update(Users user);
        bool delete(int id);

    }
}
