namespace _07.MinEl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join('-',num));

            int min=int.MaxValue;//min=7 455 322
            int max=int.MinValue;
            for (int i = 0; i < num.Length; i++)   //2 5 7 1 6
            {
                if (min > num[i])
                {
                    min = num[i];
                }

                if (max < num[i])
                {
                    max= num[i];
                }

            }

            Console.WriteLine($"min={min}");
            Console.WriteLine($"max={max}");


        }
    }
}
