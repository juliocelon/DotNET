using System;
namespace DotNetTopics
{
    public class TupleExample
    {
        // Tuple: Is a lightweight data structure to group multiple diferent data elements
        public static void Start()
        {
            (int, int) minMax = (2, 3);

            Console.WriteLine("min=[{0}], max=[{1}]", minMax.Item1, minMax.Item2);

            (int a, int, string) minMaxName = (2, 3, "name1");

            Console.WriteLine("min=[{0}], max=[{1}], name=[{2}]", minMaxName.a, minMaxName.Item2, minMaxName.Item3);

            var t1 = (a: 1, b: 2, 3);

            Console.WriteLine("a=[{0}], b=[{1}], Item3=[{2}]", t1.a, t1.Item2, t1.Item3);
        }
    }
}
