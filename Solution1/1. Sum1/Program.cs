namespace _1._Sum1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum();
            //Console.WriteLine(Sum1());
            //Console.WriteLine(Sum2(10,20));
            Sum3(3.2,2.5);
        }
        public static void Sum()
        {
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"S={a}+{b}={a+b}");
        }
        public static double Sum1()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            return a + b;
        }
        public static double Sum2(double a, double b)
        {
            return a + b;
        }
        public static void Sum3(double a, double b)
        {
            Console.WriteLine(a+b);
        }
    }
}
