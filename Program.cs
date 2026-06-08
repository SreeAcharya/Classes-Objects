namespace _01_Classes
{
    class Student
    {
        public string name;
        public int marks;

        public void PassFailCheck()
        {
            string status = (marks > 35) ? "Passed" : "Failed";
            Console.WriteLine($"The name: {name} has {status}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student1 = new Student { name = "Hari", marks = 94};
            Student student2 = new Student { name = "Elon musk", marks = 30 };
            Student student3 = new Student { name = "Aish", marks = 90 };
            Student[] AllStudents = { student1, student2, student3};

            foreach (Student no in AllStudents)
            {
                no.PassFailCheck();
            }

            
        }
    }
}
