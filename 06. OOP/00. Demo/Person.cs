using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._Demo
{
    internal class Person
    {
        public string name;
        public int age;
        public string gender;

       
        //МЕТОДИ
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {name}. I am {age} years old. Gender: {gender}");
        }

        public string LichniDanni()
        {
            return $"Az se kazvam {name}. Az sym na {age} goidni. POL: {gender}";
        }

        public override string ToString()
        {
            return $"Imeto mi e {name}. Moqta vazrast e {age} goidni. Az sam {gender}";
        }
    }
}
