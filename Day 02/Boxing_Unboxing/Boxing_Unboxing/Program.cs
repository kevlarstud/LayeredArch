using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            //Boxing num
            Object obj = num;

            //Unboxing

            //int newnum = (int)obj;

            double j=(int) obj;
            Console.WriteLine(j);

        
        }
    }
}
