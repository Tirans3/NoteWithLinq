using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 4, 8,5,6,4,9,12,36,9,0,-7,6 };
            Console.WriteLine(Linq_Method.MyAggFuncforState(ints));
            Console.WriteLine($"The multipli of 4 in ints is {Linq_Method.MyAggrFuncforMultCount(4,ints)}");
            Console.WriteLine($"The sum of ints is {Linq_Method.MyAggrFuncforSum(ints)}");

        }
    }
}
