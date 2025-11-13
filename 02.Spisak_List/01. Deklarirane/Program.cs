namespace _01._Deklarirane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[5];

            List<int> number= new List<int>();
            List<string> names= new List<string>();

            List<int> numbers = new List<int>() { 3,5,-1,6,7,8 };
            var imena = new List<string> {"Ivan", "Petar","Kiril"};

            //Печат на елементи

            Console.WriteLine(string.Join(' ',numbers));
            Console.WriteLine("=========");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("=========");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
