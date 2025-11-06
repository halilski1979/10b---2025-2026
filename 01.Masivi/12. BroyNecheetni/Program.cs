namespace _12._BroyNecheetni
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Брой нечетни числа, брой четни
            
            int[] num = { 3, 2, 1, 3, 4, 6, 5 };
            Console.WriteLine(string.Join(" ", num));
            int countOdd = 0;
            int countEven = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]%2!=0)
                {
                    Console.WriteLine(num[i]);
                    countOdd += 1;
                }
            }
            Console.WriteLine($"CountOdd: {countOdd}");

            foreach (int item in num)
            {
                if ((item % 2) == 0)
                {
                    Console.WriteLine(item);
                    countEven++; ;
                }
            }
            Console.WriteLine($"CountEven: {countEven}");
        }
    }
}
