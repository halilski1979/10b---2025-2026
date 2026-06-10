using System.Security.Cryptography.X509Certificates;

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars cars1 = new Cars();
            cars1.Brand = "BMW";
            cars1.Model = "X5";
            cars1.Year = 2020;
            cars1.EngineVolume = 3.0;
            cars1.Price = 50000;

            cars1.Print();

            //cars1.IncreasePrice(0.20);
            cars1.DecreasePrice(0.10);
            Console.WriteLine();
            cars1.Print();

            Console.WriteLine(cars1);
            

        }
    }
}
