using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods
{
    public static class Linq_Method
    {
        // Enumerable.Aggregate Method have three overloads

        // 1.In  MyAggrFuncforSum method I will show how is work Aggregate<TSource>(this IEnumerable<TSource>, Func<TSource,TSource,TSource>) overload:
        //   There we will calculate sum  of elements  sourse :
        public static int MyAggrFuncforSum(IEnumerable<int> sourse)
        {

            if (sourse == null)
                throw new ArgumentNullException();
            if (sourse.Count() == 0)
                throw new InvalidOperationException();
            return sourse.Aggregate((a, b) => a + b);
            // 1.a=sourse[0] , b = sourse[1] and reszult = sourse[0] + sourse[1];
            // 2.a=reszult, b=sourse[3] and reszult = a + sourse[3];
            //   ..................................................
        }

        // 2.In MyAggrFuncforMultCount method illustrated work of Aggregate<TSource,TAccumulate>(this IEnumerable<TSource>, TAccumulate, Func<TAccumulate,TSource,TAccumulate>) overload:
        //    This method return count multiple of x in sourse: 

        public static int MyAggrFuncforMultCount(int x, IEnumerable<int> sourse)
        {
            if (x == 0)
                throw new DivideByZeroException();
            if (sourse == null)
                throw new ArgumentNullException();
            return sourse.Aggregate(0, (a, b) => b % x == 0 && b / x != 0 ? ++a : a);

            //1. a=0,b=sourse[0] and reszult will  incrimented a if  b % x == 0 && b / x != 0 is true ,else no chenchged:
            //2. a=reszult,b=sourse[1] and reszult wil incrimented a if  b % x == 0 && b / x != 0 is true ,else no chenchged:
            //   ....................................................................................................
        }

        //1.Ilustrated Aggregate<TSource, TAccumulate, TResult>(this IEnumerable<TSource>, TAccumulate, Func<TAccumulate, TSource, TAccumulate>, Func<TAccumulate, TResult>) overlad:
        //  This method retun  information about all  elements

        public static string MyAggFuncforState(IEnumerable<int> sourse)
        {
            if (sourse == null)
                throw new ArgumentNullException();
          return sourse.Aggregate(0, (a, b) => b > 0 ? ++a : a, c => c == sourse.Count() ? "All elements are positive " : c == 0 ? "All elemrnets are negative" : "There are mixed numbers");
            // 1. a=0,b=sourse[0] and a will incrimented if b>0
            // 2. a=sourse[0]>0 ? ++a : a ;
            //        .....................
            // At last c=a,and reszult equal in this expression  c => c == sourse.Count() ? .....
        }
    }
}