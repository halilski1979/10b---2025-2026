namespace _03._Metodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int>();
            //Метод    АDD - добавя елемент на последна позиция 

            number.Add(10);
            number.Add(20);
            number.Add(30);
            number.Add(40);
            number.Add(20);

            Console.WriteLine(string.Join(',',number));
            number.Add(5);
            Console.WriteLine(string.Join(',', number));

            //Метод    Count  - връща броя на елементите 
            Console.WriteLine($"Broy elementi: {number.Count()}");

            //Метод    REMOVE()  - премахва първото срещане на елемент 
            number.Remove(20);
            Console.WriteLine(string.Join(',', number));


            //Метод    RemoveAt(index)  - премахва елемент по неговият индекс 
            number.RemoveAt(0);
            Console.WriteLine(string.Join(',', number));

            //Метод    Insert(index,element)  - вмъква елемент на дадена позиция 
            number.Insert(3, 111);
            Console.WriteLine(string.Join(',', number));
        }
    }
}
