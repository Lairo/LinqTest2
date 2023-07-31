namespace LinqTest
{
    class Program
    {
        static void Main()
        {
            //List<int> numbers = new();
            //for (int i = 1; i <= 2; i++)
            //    numbers.Add(i);
            //IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(6));
            //foreach (int i in numbers)
            //    Console.Write($"{Enumerable.Range(0, 6).Average()} ");

            int[] values = new[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result =
                from v in values
                where v < 37
                orderby -v
                select v;

            foreach (int v in result)
                Console.Write($"{v} ");
            Console.ReadLine();
        }
    }
}