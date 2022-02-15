using System;
namespace DotNetTopics
{
    // A structure is a variable of value type and live on the stack
    // A class is a variable of reference type and live on the heap
    // A structure is lighter than a class
    // Use a structure when you have simple data
    // A struct can not have null values

    public struct Point
    {
        int X;
        int Y;

        // On the constructor, you should give value to each 
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
