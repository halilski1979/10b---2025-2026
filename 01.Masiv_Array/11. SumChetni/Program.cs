namespace _11._SumChetni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 1, 3, 4, 6, 5 };
            Console.WriteLine(string.Join(" ", num));
            int s = 0;

            for (int i = 0; i < num.Length; i++)
            {
               if (num[i] % 2 == 0)
                {
                    s += num[i];
                }
                              
            }
            Console.WriteLine(s);
        }
    }
}
