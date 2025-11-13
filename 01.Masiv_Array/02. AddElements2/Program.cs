namespace _02._AddElements2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5]; 
            string[] imena=new string[] {"Ivan", "Petar", "Hristo"};

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }


            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine();
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"names[{i}]={names[i]}");
            }

        }
    }
}
