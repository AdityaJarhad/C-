using ApniDukaan.Models;
using MySql.Data.MySqlClient;


namespace ApniDukaan.Repositories
{
    public class UserRepoManager
    {
        public static User GetUser(int id)
        {
            String connStr = "server=localhost;Port=3306;Database=ApniDukaan;User=root;Password=Shiv@1234;";
            MySqlConnection conn = new MySqlConnection(connStr);
            User user = new User();
            try
            {
                conn.Open();
                String query = "select * from User where id=" + id;
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    user.Id = reader.GetInt32("id");
                    user.Name = reader.GetString("name");
                    user.Email = reader.GetString("email");
                    user.Password = reader.GetString("password");
                    user.ContactNumber = reader.GetInt32("contactNo");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                if (conn != null) 
                { 
                    conn.Close();
                }
            }

            return user;
        }
        public static List<User> GetUsers()
        {
            List<User> users = new List<User>();
            String connectionString = "Server=localhost;database=ApniDukaan;User=root;Password=Shiv@1234";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                String query = "select * from User";
                command.CommandText = query;
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    String name = reader.GetString("name");
                    String email = reader.GetString("email");
                    String password = reader.GetString("password");
                    int mo_no = reader.GetInt32("contactNo");
                    User user = new User();
                    user.Id = id;
                    user.Name = name;
                    user.Email = email;
                    user.Password = password;
                    user.ContactNumber = mo_no;
                    users.Add(user);
                }
                reader.Close();
            }
            catch (Exception ex) 
            {
                 Console.WriteLine(ex.Message);            
            }
            finally
            {
                connection.Close();
            }

            return users;
        }
        public static bool insert(User user)
        {
            if(user == null) return false;

            String connStr = "Server=localhost;Port=3306;Database=ApniDukaan;User=root;Password=Shiv@1234";
            MySqlConnection conn = new MySqlConnection(connStr);

            String query = "insert into User values('"+ user.Id+"','"+user.Name+"','"+user.Email+"','"+user.Password+"','"+user.ContactNumber+"'"+")";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteReader();

            return true;
        }
        public static bool update(User user)
        {
            if(user == null) return false;

            String connStr = "Server=localhost;Port=3306;Database=ApniDukaan;User=root;Password=Shiv@1234";
            MySqlConnection conn = new MySqlConnection(connStr);
            bool status = false;
            try
            {
                String query = "update User " +
                                "set name='" + user.Name + "', set password='"+user.Password+"' " +
                                "where id="+user.Id;
                MySqlCommand cmd = conn.CreateCommand();
                conn.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                status = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
            conn.Close(); 
            }

            return status;
        }
        public static bool delete(int id)
        {
            bool status = false;
            String connStr = "Server=localhost;Port=3306;Database=ApniDukaan;User=root;Password=Shiv@1234";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                String query = "delete from User where id=" + id;
                MySqlCommand cmd = new MySqlCommand(query,conn);
                cmd.ExecuteNonQuery();
                status = true;
            }
            catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return status;
        }
    }
}
