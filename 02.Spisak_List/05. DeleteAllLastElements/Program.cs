namespace _05._DeleteAllLastElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            number.RemoveAll(x => x == number[number.Count - 1]);
            Console.WriteLine(string.Join(' ',number));
          
        }
    }
}
