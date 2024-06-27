using Catalog;

namespace OrderProcessing
{
    public class Order
    {
        static int i = 100;
        private int id { set; get; }
        private DateTime orderDate { set; get; }
        Product product = new Product();
        String s;

        public Order(Product p) 
        {
            this.id = ++i;
            this.product = p;
            this.orderDate = DateTime.Now;
        }

        public override string ToString()
        {
            return "id : "+id+" Product : "+product.title+" Order Date : "+orderDate;
        }
    }

}
