namespace _09._Spisak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(' ', chisla));


            Console.WriteLine($"Max={chisla.Max()}");

            Console.WriteLine();
            int min = chisla.Min();
            chisla.Remove(min);
            Console.WriteLine(string.Join(' ', chisla));

            Console.WriteLine();
            chisla.Reverse();
            Console.WriteLine(string.Join(' ', chisla));

            Console.WriteLine();
            chisla=chisla.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(' ', chisla)); 
        }
    }
}
