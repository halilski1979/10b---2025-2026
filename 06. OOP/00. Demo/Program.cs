namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();
            p.name = "Petar";
            p.age = 23;
            p.gender = "momche";

            Person q= new Person();
            q.name = "Maria";
            q.age = 25;
            q.gender = "momiche";

            Console.WriteLine($"Name: {p.name}, {p.age} years old. Gender: {p.gender}");
            Console.WriteLine($"Name: {q.name}, {q.age} years old. Gender: {q.gender}");

            //void-МЕТОД
            Console.WriteLine();
            p.IntroduceYourself();
            q.IntroduceYourself();

            //ВРЪЩАЩ РЕЗУЛТАТ
            Console.WriteLine();
            Console.WriteLine(p.LichniDanni());
            Console.WriteLine(q.LichniDanni());

            Console.WriteLine();
            Console.WriteLine(p);
            Console.WriteLine(q);


            Cars car1 = new Cars();
            Cars car2= new Cars();  
            Cars car3= new Cars();

            car1.brand = "BMW";
            car1.model = "X5";
            car1.fuel = "diesel";
            car1.age = 23;
            car1.color= "red";

        }
    }
}
