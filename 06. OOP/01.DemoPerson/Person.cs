using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DemoPerson
{
    public class Person
    {
		//поле - field
		private string name;
        private int age;
        private string gender;
        private double salary;

        //свойство - property
        public string Name
		{
			get { return name; }
			set { name = value; }
		}		
		public int Age
		{
			get { return age; }
			set { age = value; }
		}		
		public string Gender
		{
			get { return gender; }
			set { gender = value; }
		}			
		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}


		public void Print()
		{
            Console.WriteLine($"Kazvam se {Name}, na {Age} godini. Zaplata: {Salary:f2} EURO");
		}

		public void IncreaseSalary(double percent)
		{
			Salary = Salary * percent + Salary;
		}



	}
}
