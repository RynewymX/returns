using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returns
{
    internal class Program
    {
        static int MyMethod(int x)
        {
            return 5 + x;
        }

        static decimal AdditionCalc(decimal y, decimal z)
        {
            return y + z;
        }

        static decimal Subtraction(decimal a, decimal b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MyMethod(5));
            Console.WriteLine(AdditionCalc(5, 10));
            Console.WriteLine(Subtraction(100, 50));
            Console.ReadLine();
        }
    }
}
