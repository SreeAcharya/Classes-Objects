namespace _04_C_M
{
    class Employee
    {
        public string name;
        public int salary;

        public void BonusChecker()
        {
            string result = (salary >= 30000) ? "Bonus = 5000" : "Bonus = 2000";
            Console.WriteLine($"Name:{name}, with the Salary:{salary}, has {result}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Employee1 = new Employee { name = "Hari", salary = 30001};
            Employee Employee2 = new Employee { name = "Ravi", salary = 20001 };
            Employee Employee3 = new Employee { name = "Elon", salary = 10000 };
            Employee Employee4 = new Employee { name = "Jensen", salary = 3001 };
            Employee Employee5 = new Employee { name = "Steve jobs", salary = 400001 };
            Employee Employee6 = new Employee { name = "Ramu", salary = 30001 };
            Employee Employee7 = new Employee { name = "Rajesh", salary = 50000 };

            Employee[] Employees = { Employee1, Employee2, Employee3, Employee4, Employee5, Employee6, Employee7 };
            foreach (Employee emp in Employees)
            {
                emp .BonusChecker();
            }

        }
    }
}
