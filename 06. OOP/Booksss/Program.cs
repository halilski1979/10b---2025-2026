namespace Booksss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books();

            book1.Title = "The Great Gatsby";
            book1.Author = "F. Scott Fitzgerald";
            book1.YearPublished = 1925;
            book1.Rating = 9.0;
            book1.Price = 25.50;

            book1.Print();
            Console.WriteLine(book1.Info());
            Console.WriteLine(book1);


            Console.WriteLine();
            book1.IncreasePrice(0.10);
            Console.WriteLine(book1);



        }
    }
}
