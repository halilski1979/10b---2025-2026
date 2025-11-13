namespace _08._MetodiMasivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(' ',num));

            Console.WriteLine($"S={num.Sum()}");
            Console.WriteLine($"Min={num.Min()}");
            Console.WriteLine($"Max={num.Max()}");

            Console.WriteLine();
            Console.WriteLine(num.First());
            Console.WriteLine(num[0]);

            Console.WriteLine();
            Console.WriteLine(num.Last());
            Console.WriteLine(num[num.Length-1]);
        }
    }
}
