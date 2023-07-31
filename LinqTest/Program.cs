namespace LinqTest
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new();
            for (int i = 1; i <= 99; i++)
                numbers.Add(i);
            IEnumerable<int> firstAndLastFive = numbers.Take(5).Concat(numbers.TakeLast(6));
            foreach (int i in Enumerable.Range(1, 20))
                Console.Write($"{i} ");

            //IEnumerable<int> bob = numbers.Range(8, 5);

            //Console.WriteLine(Enumerable.Range(8, 5));

        }
    }
}