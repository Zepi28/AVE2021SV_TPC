using System;
using System.Collections.Generic;
using System.Reflection;

namespace TPC02
{
    class Program
    {
        static void Main(string[] args)
        {

            var dll = Assembly.LoadFrom(@"C:\Users\A44835\Documents\Isel\Semestre atual\AVE\github\ave-2020-21-sem2-i41d\aula03-reflection\RestSharp.dll");
            Type[] typeArray = dll.GetTypes();
            printInfo(typeArray);

            Console.ReadLine();
        }

        static void printInfo(Type[] type)
        {
            MethodInfo[] methodArray;
            foreach (Type t in type)
            {
                methodArray = t.GetMethods();
                Console.WriteLine("Type: {0}", t);
                foreach (MethodInfo idx in methodArray)
                {
                    Console.WriteLine("Method: {0}", idx);
                }
                Console.WriteLine();
            }
        }
    }
}
