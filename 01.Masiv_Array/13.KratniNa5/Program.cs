namespace _13.KratniNa5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 8, 10, 15, 25, 28 };
            int count5 = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 5 == 0)
                {
                    count5++;
                }
                    
            }
            Console.WriteLine($"Count5: {count5}");
        }
    }
}
