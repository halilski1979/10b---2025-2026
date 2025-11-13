namespace _01._AddElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вход от 1 ред
            int[] num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //Печат 1
            Console.WriteLine(string.Join('-',num));

            Console.WriteLine();
            //Печатt 2
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            //Печат 3
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

        }
    }
}
