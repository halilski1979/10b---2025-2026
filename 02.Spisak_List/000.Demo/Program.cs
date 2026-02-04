namespace _000.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>() {3,6,7,11,7,22 };

            Console.WriteLine(string.Join(' ',number));
            
            number.Add(100);
            Console.WriteLine(string.Join(' ', number));

            Console.WriteLine($"Count: {number.Count()}");

            number.Remove(7);
            Console.WriteLine(string.Join(' ', number));

            number.RemoveAt(0);
            Console.WriteLine(string.Join(' ', number));

            number.Insert(0,222);
            Console.WriteLine(string.Join(' ', number));

            Console.WriteLine(number.Contains(101));

            number=number.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(' ', number));

            number.Reverse();
            Console.WriteLine(string.Join(' ', number));
        }
    }
}
