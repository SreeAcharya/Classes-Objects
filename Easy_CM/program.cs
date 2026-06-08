namespace Easy_CM
{
    class Product
    {
        public string name;
        public double price;
        public int stockQty;

        public Product(string InputName, double InputPrice, int InputStockQty)
        {
            name = InputName;
            price = InputPrice;
            stockQty = InputStockQty;
        }
        public void DisDetails()
        {
            Console.WriteLine($"Company name:{name}, Price:{price}, StockQty:{stockQty}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product one = new Product("Laptop", 83000, 5);
            Product two = new Product("Specs", 5000, 50);
            Product three = new Product("Mobiles", 50000, 9);

            one.DisDetails();
            two.DisDetails();
            three.DisDetails();
        }
    }
}
