namespace _06.StringUpperLower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Ivan";
            string lastName = "Petrov";

            Console.WriteLine($"{firstName} {lastName}");
            
            Console.WriteLine($"{firstName.ToLower()} {lastName.ToUpper()}");
        }
    }
}
