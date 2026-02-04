namespace _08._MasiviSpsaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            List<int> chisla=Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(' ',numbers));
            Console.WriteLine(string.Join(' ', chisla));



            Console.WriteLine();
            //Pechat chetni
            int sChetni = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine(numbers[i]);
                    sChetni += numbers[i];
                }
            }
            Console.WriteLine($"sChetni={sChetni}");

            Console.WriteLine();
            Console.WriteLine($"sMasiv={numbers.Sum()}");
            Console.WriteLine($"sMasiv={chisla.Sum()}");


            int sNegative = 0;
            int brNegative = 0;
            for (int i = 0; i < chisla.Count; i++)
            {
                if (chisla[i]<0)
                {
                    sNegative += chisla[i];
                    brNegative++;
                }
            }

            Console.WriteLine($"sNegative: {sNegative}");
            Console.WriteLine($"brNegative: {brNegative}");

            int sNech = 0;
            int countNechetni = 0;
            for (int i = 0; i < chisla.Count; i++)
            {
                if (chisla[i] % 2 != 0 && chisla[i]>0)
                {
                    sNech += chisla[i];
                    countNechetni++;
                }
            }
            double avg = sNech / countNechetni;
            Console.WriteLine($"avgSpisakNechetni: {avg}");
        }
    }
}
