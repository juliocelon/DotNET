using System;
using DotNetTopics;

namespace GenericsOnDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //ValueAndRefTypes.Test();

            //GenericClass<bool> gc1 = new GenericClass<bool>(true);

            //GenericClass<string> gc11 = new GenericClass<string>("message");

            //GenericClassWithTwoTypes<Exception, int> gc = new GenericClassWithTwoTypes<Exception, int>(5);
            //gc.Proccess(6);

            //GenericClassWithTwoTypes<Exception, string> gc2 = new GenericClassWithTwoTypes<Exception, string>("message");
            //gc2.Proccess("to process");

            //Enums.Execute();

            //Arrays.Execute();

            //ParamsExample.Sum(1,2,3);

            //// method of extention
            //string message = "It is a test of methods of extention";
            //message.CountWords();

            //LINQExercises.Start();

            //TupleExample.Start();

            StringInterpolationExample.Start();
        }
    }
}
