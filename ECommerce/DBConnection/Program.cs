using MySql.Data.MySqlClient;
using System.Security.Cryptography;


String connectionString = "Server=localhost;Port=3306;Database=iacsd0324;User=root;Password=Shiv@1234";
MySqlConnection connection = new MySqlConnection(connectionString);

try
{
    connection.Open();
    String query = "select * from product;";
    MySqlCommand command = connection.CreateCommand();
    command.CommandText = query;
    MySqlDataReader reader = command.ExecuteReader();
    while (reader.Read())
    {
        // pid | pname | qty  | price | cust |
        int id = reader.GetInt32("pid");
        String name = reader.GetString("pname");
        int qty = reader.GetInt32("qty");
        int price = reader.GetInt32("price");
        //int cust = reader.GetInt32("cust");

        Console.WriteLine(id + " " + name + " " + qty + " " + price + " " );
    }
    reader.Close();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
connection.Close();