using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangularArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 },{ 4, 5, 6 } };
            for (int i = 0; i<=1;i++)
            {
                for(int j=0;j<=2;j++)
                {
                    Console.Write(arr[i,j]);
                    Console.Write(" ");
                    
                }
                Console.Write("\n");
            }
        }
    }
}
