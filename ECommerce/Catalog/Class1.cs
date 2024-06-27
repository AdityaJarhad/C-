namespace Catalog
{
    public class Product
    {
        static int i = 0;
        public int id { set; get; }
        public string title {  set; get; }
        private double unitPrice {  set; get; }

        public Product() { }

        public Product(string title, double unitPrice)
        {
            this.id = ++i;    
            this.title = title;
            this.unitPrice = unitPrice;
        }

        public override string ToString() 
        {
            return "id : "+id+" title : "+title+" untPrice : "+unitPrice;
        }

        

    }
}
