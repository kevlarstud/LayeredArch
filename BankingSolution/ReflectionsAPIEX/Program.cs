using System;
using System.Collections.Generic;
using System.Reflection;

namespace ReflectionsAPIEX
{
    class Calculation
    {

        public static int AddTwoNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly asmobj = Assembly.LoadFile
            //    (@"C:\Users\rk_sh\documents\visual studio 2013\Projects\BankingSolution\BankClassLiB\bin\Debug\BankClassLiB.dll");
            Assembly asmobj = Assembly.GetExecutingAssembly();
            Type[] tobj = asmobj.GetTypes();
            foreach (var titem in tobj)
            {
                Console.WriteLine("Classes in the Library are: {0}",titem.Name);
                Console.WriteLine("-----------------------------------");
                MethodInfo[] mobj = titem.GetMethods();
                foreach (var mitem in mobj)
                {
                    Console.WriteLine("Methods inn the class are: {0}",mitem.Name);
                    Console.WriteLine("-------------------------------------------");
                   ParameterInfo[] probj = mitem.GetParameters();
                    foreach (var pritem in probj)
                    {
                        Console.WriteLine
                            ("parameters in this method are :{0} and it's type is: {1}",
                            pritem.Name, pritem.ParameterType);
                    }
                    PropertyInfo[] pobj = titem.GetProperties();
                    foreach (var pitem in pobj)
                    {
                        Console.WriteLine("Properties in this class are {0}",pitem.Name);
                    }
                }
            }
        }
    }
}
