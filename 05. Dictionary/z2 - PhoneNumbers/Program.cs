using System.ComponentModel;

namespace z2___PhoneNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,string> phoneNum=new Dictionary<string,string>();

             while (true)
            {
                var cmd=Console.ReadLine().Split(' ').ToList();
                if (cmd[0]=="End")
                {
                    break;  
                }

                if (cmd[0]=="A")
                {
                    string name = cmd[1];
                    string phone = cmd[2];

                    if (phoneNum.ContainsKey(name))
                    {
                        phoneNum[name] = phone;
                    }
                    else
                    {
                        phoneNum.Add(name, phone);
                    }
                       
                }

                if (cmd[0] == "S") 
                { 
                    string name = cmd[1];
                    if (phoneNum.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneNum[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist");
                    }
                }
            }
        }
    }
}
