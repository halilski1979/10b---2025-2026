namespace _02._OddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Even(4));
        }
        public static bool Even(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
