namespace _04._StringReplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cocktail = "Vodka + Martini + Cherry";
            string newCocktail = cocktail.Replace('+','i');
            Console.WriteLine(newCocktail);
        }
    }
}
