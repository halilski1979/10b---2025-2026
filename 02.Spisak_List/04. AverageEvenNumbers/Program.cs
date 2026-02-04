namespace _04._AverageEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new List<double>() {1,2,3,4,5,6};

            int counter = 0;
            double s = 0;

            foreach (var item in number)
            {
                if (item%2==0)
                {
                    counter++;
                    s += item;
                    Console.WriteLine(item);
                }
            }

            //double average=s/counter;
            Console.WriteLine($"Average: {s / counter}");
        }
    }
}
