namespace _06._RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //1 2 3 4 5 1 2 3 5 

            int lastNumber = num[num.Count - 1];
            int lastNum = num.LastOrDefault();

            //Console.WriteLine(lastNumber);
            //Console.WriteLine(lastNum);

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]==lastNum)
                {
                    num.Remove(num[i]);
                }
            }

            Console.WriteLine(string.Join(' ',num));
        }
    }
}
