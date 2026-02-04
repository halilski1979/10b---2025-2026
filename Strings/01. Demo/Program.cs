namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string email = "vasko@gmail.org";
            int firstIndex=email.IndexOf("a");
            Console.WriteLine(firstIndex);

            string verse = "To be or not to be";
            int lastIndex=verse.LastIndexOf("be");
            int firstIndexBe=verse.IndexOf("be");
            Console.WriteLine(firstIndexBe);
            Console.WriteLine(lastIndex);

            Console.WriteLine();
            string filename = @"C:\Pics\Rila2017.jpg";
            string namefile = filename.Substring(8,8);
            Console.WriteLine(namefile);


        }
    }
}
