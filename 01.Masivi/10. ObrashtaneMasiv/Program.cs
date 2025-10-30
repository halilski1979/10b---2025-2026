namespace _10._ObrashtaneMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Обръщане на елементите на масив - Reverse()

            string[] names = { "Petar", "Kiko", "Ivan", "Maria" };

            Console.WriteLine(string.Join(" ",names));

            names=names.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", names));


            names=names.OrderBy(x=>x).ToArray();
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
