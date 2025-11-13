namespace _09._SortMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сортиране =>   names=names.OrderBy(x=>x).ToArray();

            int[] num = { 3, 5, 1, 3, 4, 6, 5 };
            Console.WriteLine(string.Join(" ",num));

            //Сортиране на масив - I начин
            Array.Sort(num);
            Console.WriteLine(string.Join(" ", num));


            string[] names = { "Petar", "Asen", "iVAN", "Niki", "Valq", "Kiril", "Lamin Yamal"};
            //Сортиране на масив - II начин
            names=names.OrderBy(x=>x).ToArray();
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
