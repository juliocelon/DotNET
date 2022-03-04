using System;
namespace DotNetTopics
{
    public class ParamsExample
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine("Sum=[{0}]", sum);
            return sum;
        }
    }
}
