namespace _04._AddElementsChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] symbols = new char[4];

            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < symbols.Length; i++)
            {
                Console.WriteLine($"symbols[{i}]= {symbols[i]}");
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(' ',symbols));

        }
    }
}
