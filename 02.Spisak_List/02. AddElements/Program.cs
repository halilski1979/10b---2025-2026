namespace _02._AddElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(';',number));

        }
    }
}
