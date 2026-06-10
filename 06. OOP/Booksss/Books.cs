using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksss
{
    internal class Books
    {
		private string title;

		private string author;
		private int yearPublished;
		private double rating;
		private double price;
		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		

		public string Author
		{
			get { return author; }
			set { author = value; }
		}
		

		public int YearPublished
		{
			get { return yearPublished; }
			set { yearPublished = value; }
		}
		

		public double Rating
		{
			get { return rating; }
			set { rating = value; }
		}
		

		public double Price
		{
			get { return price; }
			set { price = value; }
		}
		public void Print()
		{
            Console.WriteLine($"Knigata {Title} ot {Author}, izdana prez {YearPublished}, ima rating {Rating},cena: {Price}");
		}

		public string Info()
		{
			return $"Zaglavie: [{Title}], Avtor: [{Author}], Godina: [{YearPublished}], Ocenka: [{Rating}]/10,Cena: [{Price}] lv.";
		}

        public void IncreasePrice(double percentage)
		{
			Price=Price+Price*percentage;
		}

        public void DecreasePrice(double percentage)
		{
            Price = Price - Price * percentage;
        }

        public override string ToString()
        {
			return $"Book: [{Title}] by [{Author}], published in [{YearPublished}], rating: [{Rating}]/10, price:[{Price}] lv";
        }
    }
}
