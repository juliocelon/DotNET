using System;
namespace DotNetTopics
{
    /*
     To create a method of extention, it should be created on a static class, and the method should be also static
     */
    public static class MethodOfExtention
    {
        // "this" on the arguments refers to the type of data that you want to extend
        public static int CountWords(this string message)
        {
            return message.Split(" ").Length;
        }
    }
}
