using System;
namespace GenericsOnDotNet
{
    public class ValueAndRefTypes
    {
        public ValueAndRefTypes()
        {
        }
            
        public static void Test()
        {
            // NULLABLE TYPE
            int? i = null;
            // Properties HasValue and Value
            if (!i.HasValue)
                i = 10;
            else
                System.Console.WriteLine(i.Value);

            // REF PARAMETERS
            int input = 5;
            functionWithRef(ref input);
            System.Console.WriteLine(input);

            static void functionWithRef(ref int input)
            {
                input++;
            }

            // OUT PARAMETERS
            // With out parameter, you can send a parameter not initialized
            int input2;
            functionWithOut(out input2);
            System.Console.WriteLine(input2);

            static void functionWithOut(out int input2)
            {
                input2 = 1;
                input2++;
            }

            // Another example of a use of out parameter
            int.TryParse("5", out int result);
            System.Console.WriteLine(result);

            // SYSTEM.OBJECT - BOXING AND UNBOXING

            int value = 50;
            object object1 = value; // boxing
            int value2 = (int)object1; // Unboxing with cast -> (int)

            if(object1 is int) // IS OPERATOR
                Console.WriteLine("Object of type int");

            object object2 = "message";
            string value3 = object2 as string; // AS OPERATOR - just return null if cannot make the cast
            if (value3 != null)
            {
                Console.WriteLine(value3);
            }
        }

    }
}
