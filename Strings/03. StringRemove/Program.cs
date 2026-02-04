namespace _03._StringRemove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string price = "1234567";
            string newPrice = price.Remove(3,2);
            Console.WriteLine(newPrice);

            string planina = "Rila planina";
            string newPlanina=planina.Remove(4);
            Console.WriteLine(newPlanina);
        }
    }
}
