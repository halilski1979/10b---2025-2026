namespace z1___words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words=Console.ReadLine().ToLower().Split(' ').ToList();

            var dumi = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (dumi.ContainsKey(item))
                {
                    dumi[item]++;
                }
                else
                {
                    dumi.Add(item, 1);
                }
            }

            foreach (var item in dumi)
            {
                if (item.Value%2==1)
                {
                    Console.Write($"{item.Key},");
                }
            }
        }
    }
}
