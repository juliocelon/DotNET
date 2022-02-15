using System;
namespace GenericsOnDotNet
{
    public class GenericClass<T> 
    {
        T dato;

        public GenericClass(T _dato)
        {
            dato = _dato;
        }

        public T Proccess(T input)
        {
            return input;
        }
    }


    public class GenericClassWithTwoTypes<T, U> where T: Exception // Restriction to the generic class as type Exception
    {
        T dato;
        U dato2;

        public GenericClassWithTwoTypes(U _dato)
        {
            dato2 = _dato;
        }

        public U Proccess(U input)
        {
            return input;
        }
    }
}
