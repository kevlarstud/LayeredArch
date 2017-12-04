using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;
namespace CalculatorUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int n2 = int.Parse(Console.ReadLine());
            int result = MathClass.Add(n1, n2);
            Console.WriteLine(result);
        }
    }
}
