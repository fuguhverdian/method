using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodlatihan
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();
            Console.WriteLine("minimum #1 :{0}", number.FindMininum(3, 1));
            Console.WriteLine("minimum #2 :{0}", number.FindMininum(3, 2,4));
            Console.WriteLine();
            Console.WriteLine("maximum #1 :{0}", number.FindMaximum(3, 1));
            Console.WriteLine("maximum #2 :{0}", number.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
