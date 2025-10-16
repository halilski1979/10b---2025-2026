using System.Runtime.ConstrainedExecution;

namespace _001._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Добавяне на елементи от 1 ред
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(' ',num));
            Console.WriteLine();

            foreach (var item in num) { Console.WriteLine(item); }

            for (int i = 0; i < num.Length; i++) { Console.WriteLine(i); }
        }
    }
}
