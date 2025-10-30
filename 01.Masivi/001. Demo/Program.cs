using System.Runtime.ConstrainedExecution;

namespace _001._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Добавяне на елементи от 1 ред

            double[] nums = { 3.34, 1.23, 5.5, 6.6, 7.3 };

            Console.WriteLine(string.Join(' ', nums));
            nums = nums.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(' ', nums));

            nums = nums.Reverse().ToArray();
            Console.WriteLine(string.Join(' ', nums));

            Console.WriteLine(nums.Sum());

            Console.WriteLine(nums.Min());

            Console.WriteLine(nums.Max());

            Console.WriteLine(nums.Length);
        }
    }
}
