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
            int[] ints = { 4,6,9,1,0,8,69,3,2,0,4,-56 };
            Console.WriteLine($"1 . Inform about state  '{Linq_Method.MyAggFuncforState(ints)}'");
            Console.WriteLine($"2 . The multipli of 4 in ints is {Linq_Method.MyAggrFuncforMultCount(4,ints)}");
            Console.WriteLine($"3 . The subtraction of ints is {Linq_Method.MyAggrFuncforSub(ints)}");
            Console.WriteLine("4 . All elements of ints are {0} than 10",(Linq_Method.MyAggFuncAll(10,ints)?"big":"less"));
            Console.WriteLine("5 . ints {0} element in (1,10)" ,(Linq_Method.MyAggFuncAny(1,10,ints))?"have":"havn't");
            Console.ReadLine();
        }
    }
}
