namespace _02_C_M
{
    class Product
    {
        public string name;
        public int price;
        public int quantity;

        public void ProductDisplay()
        {
            Console.WriteLine($"Name:{name}, Cost:{price}, Qty:{quantity}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { name = "Cycle", price = 5000, quantity = 1};
            Product product2 = new Product { name = "Mobiles", price = 100000, quantity = 3};
            Product product3 = new Product { name = "Specs", price = 9000, quantity = 2 };

            Product[] AllProducts = { product1, product2,product3};
            foreach (Product eachProduct in AllProducts)
            {
                eachProduct.ProductDisplay(); 
            }

        }
    }
}
