namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Деклариране на речник(асоциативен масив)
            Dictionary<string,int> nameMoney= new Dictionary<string,int>();
            var phoneNumber = new Dictionary<string,string>();

            //Добавяне на елементи към речник
            Console.Write("Broy elmenti: ");
            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split(' ').ToList(); //Ivan 100
                string name=cmd[0];
                int money=int.Parse(cmd[1]);

                if (nameMoney.ContainsKey(name))
                {
                    nameMoney[name] = money;
                }
                else
                {
                    nameMoney.Add(name, money);
                    //nameMoney[name] = money;
                }
            }

            foreach (var item in nameMoney)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
    }
}
