using ORM_Tester;

IDbManager dbManager = new DbManager();
bool exit = true;
while (exit)
{
    Console.WriteLine("\nEnter choice " +
        "\n1. Get all Users" +
        "\n2. Delete user" +
        "\n3. Update" +
        "\n4. Insert" +
        "\n0. Exit");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            List<Users> users = dbManager.getUsers();
            foreach (var item in users)
            {
                Console.WriteLine(item.id + " " + item.name + " " + item.email + " " + item.contactNo);
            }
            break;
        case 2:
            Console.WriteLine("Enter Id to delete");
            int id = int.Parse(Console.ReadLine());
            dbManager.delete(id);
            break;
        case 3:
            var update = new Users()
            {
                id = 4,
                email = "a1@gmail.com",
                password = "123"
            };
            dbManager.update(update);
            Console.WriteLine("update successful");
            break;
        case 4:
            Console.WriteLine("Enter name");
            String nm = Console.ReadLine();
            Console.WriteLine("Enter email");
            String em = Console.ReadLine();
            Console.WriteLine("Enter password");
            String pwd = Console.ReadLine();
            Console.WriteLine("Enter contact num");
            String num = Console.ReadLine();
            var newUser = new Users()
            {
                name = nm,
                email = em,
                password = pwd,
                contactNo = num
            };
            dbManager.insert(newUser);
            break;
        default:
            exit = false;
            break;
    }
}