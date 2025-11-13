namespace _06._SumMasivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(',',numbers));

            int sum = 0;
            int pr = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                //sum = sum + numbers[i];
                sum += numbers[i];

                //pr=pr*numbers[i];
                pr*=numbers[i];
            }

            Console.WriteLine($"S={sum}");
            Console.WriteLine($"P={pr}");
        }
    }
}
