using System.Globalization;

namespace _02.Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] left= {1,2,3,4,5};
            int [] right= {6,7,8,9};

            int [] leftRight=left.Concat(right).ToArray();

            Console.WriteLine(string.Join(' ',left));
            Console.WriteLine(string.Join(' ', right));
            Console.WriteLine(string.Join(' ', leftRight));

            
        }
    }
}
