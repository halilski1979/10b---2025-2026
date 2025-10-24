using System.Runtime.ConstrainedExecution;

namespace _001._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Добавяне на елементи от 1 ред
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var newNum=num.OrderByDescending(x=>x).Take(3).ToArray();
            Console.WriteLine(string.Join(' ',newNum));
        }
    }
}
