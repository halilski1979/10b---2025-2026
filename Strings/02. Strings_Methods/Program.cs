
namespace _02._Strings_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = "Superman";
            int newNum = num.IndexOf("r");
            Console.WriteLine(newNum);

            string newWord=num.Substring(5,2);
            Console.WriteLine(newWord);
        }
    }
}
