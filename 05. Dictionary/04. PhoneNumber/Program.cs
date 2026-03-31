namespace _04._PhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

            Console.Write("Broy zapisi: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split(' ').ToList();

                string name=data[0];
                string number=data[1];

                if (phoneNumbers.ContainsKey(name))
                {
                    phoneNumbers[name] = phoneNumbers[name] + number;
                }
                else
                {
                    phoneNumbers.Add(name, number);
                }
            }
                    

            foreach (var item in phoneNumbers)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}
