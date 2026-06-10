using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Cars
    {
		private string brand;
        private string model;
        private int year;
        private double engineVolume;
        private double price;

        public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}	
		public string Model
		{
			get { return model; }
			set { model = value; }
		}		
		public int Year
		{
			get { return year; }
			set { year = value; }
		}	
		public double EngineVolume
		{
			get { return engineVolume; }
			set { engineVolume = value; }
		}		
		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public void Print()
		{
            Console.WriteLine($"Avtomobil: [{Brand}] [{Model}], godina: [{Year}], dvigatel: [{EngineVolume}]L, cena: [{Price}] lv.");
		}

        public void IncreasePrice(double percentage)
		{
			Price=Price+Price*(percentage);
		}

        public void DecreasePrice(double percentage)
		{
            Price = Price - Price * (percentage);
        }

        public override string ToString()
        {
			return $"Car: [{Brand}] [{Model}], Year: [{Year}], Engine: [{EngineVolume}]L, Price: [{Price}] lv.";
        }
    }
}
