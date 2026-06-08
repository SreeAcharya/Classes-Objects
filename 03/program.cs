namespace _03_C_M
{
    class Number
    {
        public int value;

        public void EvenOddChecker()
        {
            string result = (value % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"The Value:{value} is {result}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Number no1 = new Number {value = 652};
            Number no2 = new Number { value = 6527 };
            Number no3 = new Number { value = 65262 };
            Number no4 = new Number { value = 6523 };
            Number no5 = new Number { value = 6522 };
            Number no6 = new Number { value = 652952 };

            Number[] nos = { no1, no2, no3, no4, no5, no6 };
            foreach (Number no in nos)
            {
                no.EvenOddChecker();
            }
        }
    }
}
