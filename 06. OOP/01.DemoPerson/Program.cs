namespace _01.DemoPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Ivan";
            p.Age = 25;
            p.Gender = "male";
            p.Salary = 2250.55;

            Person q= new Person();
            q.Name = "Petq";
            q.Age = 35;
            q.Gender = "female";
            q.Salary = 1500.34;


            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}. Gender: {p.Gender}. Salary: {p.Salary} EURO");
            Console.WriteLine($"Name: {q.Name}, Age: {q.Age}. Gender: {q.Gender}. Salary: {q.Salary} EURO");

            Console.WriteLine();
            p.Print();
            q.Print();

            p.IncreaseSalary(0.15);
            q.IncreaseSalary(0.15);

            Console.WriteLine();
            p.Print();
            q.Print();

        }
    }
}
