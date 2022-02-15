using System;
namespace DotNetTopics
{
    public class Arrays
    {
        public static void Execute()
        {
            int[] a1 = { 1, 2, 3, 4, 5 };

            int[] a2 = new int[a1.Length-1];

            Array.Copy(a1, 1, a2, 0, a1.Length - 1);

            PrintArray(a1);
            PrintArray(a2);

        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(i<array.Length-1)
                    Console.Write("{0},",array[i]);
                else
                    Console.Write("{0}", array[i]);
            }
            Console.WriteLine();
        }
    }
}
