namespace _01.LINQ_Masiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 22, 18, 1, 7, 3, 4, 9, 6, 8, 4, 12, 9,22,7 };
            Console.WriteLine(string.Join(' ',nums));
                       

            var newNums=nums.Where(x=>x%2==0).ToArray();
            Console.WriteLine();
            Console.WriteLine(string.Join(' ',newNums));
            Console.WriteLine(string.Join(' ', nums));

            Console.WriteLine($"Broy elementi na nov masiv {newNums.Count()}");
                               

            //ВАЖНО: само Select може да променя елементите в масива(списъка)
            var nums1 = nums.Select(x => x * 10).ToArray();
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', nums));
            Console.WriteLine(string.Join(' ', nums1));

            
            //Взема числата, които не се повтарят - метод Distinct
            var distinctNum=nums.Distinct().ToArray();
            Console.WriteLine();
            Console.WriteLine(string.Join(' ', nums));
            Console.WriteLine(string.Join(' ', distinctNum));







        }
    }
}
