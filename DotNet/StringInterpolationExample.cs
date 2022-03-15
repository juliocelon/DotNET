using System;
namespace DotNetTopics
{
    public class StringInterpolationExample
    {
        /*
        
        String interpolation is used to format and manipulate strings.

        This feature was introduced in C# 6.

        Using string interpolation, we can use objects and expressions as a part of the string interpolation operation.

        C# string interpolation is a method of concatenating, formatting and manipulating strings.

        >> An interpolated string is a string that might contain interpolation expressions, where each item is replaced
            by the string representations, it is identified with $ character

        The $ special character identifies a string literal as an interpolated string.
        An interpolated string is a string literal that might contain interpolation expressions.
        When an interpolated string is resolved to a result string,
            items with interpolation expressions are replaced by the string representations of the expression results.

        This feature is available starting with C# 6.

        String interpolation provides a more readable, convenient syntax to format strings.

        It's easier to read than string composite formatting.

         */

        public static void Start()
        {
            string name = "Joseph";
            string message = $"Hi, my name is {name}";
            Console.WriteLine(message);
        }
    }
}
