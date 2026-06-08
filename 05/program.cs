namespace _05_C_M
{
    class Reactangle
    {
        public int length;
        public int width;

        public void RectArea()
        {
            int area = length * width;
            Console.WriteLine($"Area:{area}");
            //return area;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Reactangle Rectangle1 = new Reactangle { length = 1, width = 2};
            Reactangle Rectangle2 = new Reactangle { length = 1, width = 3 };
            Reactangle Rectangle3 = new Reactangle { length = 1, width = 4 };
            Reactangle Rectangle4 = new Reactangle { length = 1, width = 25 };

            Reactangle[] AllRectangle = {Rectangle1, Rectangle2, Rectangle3, Rectangle4};

            foreach (Reactangle i in AllRectangle)
            {
                i.RectArea();
            }

        }
    }
}
