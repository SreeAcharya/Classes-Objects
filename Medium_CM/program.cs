namespace Medium_CM
{
    class BankAccount
    {
        public string accNo;
        public double balance;

        public BankAccount(string inputaccNo, double InitialDeposit)
        {
            accNo = inputaccNo;
            balance = InitialDeposit;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance = +amount;
                Console.WriteLine($"Total Balance:{balance} ");
            }
            else
            {
                Console.WriteLine("Can't insert negative amount");
            }
        }
        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Kindly input positive no");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Total Balance:{balance} ");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount MyAccount = new BankAccount("ACC123", 500.00);
            MyAccount.Deposit(100);
            MyAccount.Deposit(-50);

            MyAccount.Withdraw(200);
            MyAccount.Withdraw(900);

        }
    }
}
