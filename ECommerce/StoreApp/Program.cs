using Catalog;
using OrderProcessing;

List<Product> plist = new List<Product>();
List<Order> olist = new List<Order>();

Boolean exit = true;

while (exit)
{
    Console.WriteLine("\nEnter 1. i/p in product\n2. i/p in order\n3. display products\n4.display orders\n0. Exit");
    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Enter title : ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Unit Price : ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Product product1 = new Product(title, price);
            plist.Add(product1);
            break;
        case 2:
            plist.ForEach(p => Console.WriteLine(p));
            Console.WriteLine("Enter pid to order product");
            int id = int.Parse(Console.ReadLine());

            plist.ForEach(v =>
            {
                if (id == v.id)
                {
                    olist.Add(new Order(v));
                }
            });
            break;
        case 3:
            plist.ForEach(p => Console.WriteLine(p));
            break;
        case 4:
            olist.ForEach(p => Console.WriteLine(p));
            break;
        default:
            exit = false;
            break;
    }
}