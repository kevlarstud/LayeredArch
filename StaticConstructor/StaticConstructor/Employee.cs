using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Employee
    {
        public static int Count;
        static Employee()
        {
            Count = 1;
        }

    }
}
