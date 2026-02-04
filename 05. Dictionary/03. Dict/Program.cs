namespace _03._Dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nameMoney=new Dictionary<string, double>();

            nameMoney.Add("Ivan",100);
            nameMoney.Add("Asen",500);
            nameMoney.Add("Petar", 500);
            nameMoney.Add("Kiko", 500);


            foreach (var item in nameMoney)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
