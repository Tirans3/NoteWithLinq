using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethods
{
    class LinqExercises

    {     
           //  Exercisese 1
           //   Write a program in C# Sharp to find the +ve numbers from 
           //   a list of numbers using two where conditions in LINQ Query.

        public static IEnumerable<int> PositiveList(IEnumerable<int> a)
        {
            // 
            var b =
            from VrNum in a
            where VrNum > 0
            where VrNum < 12
            select VrNum;

            // By extension methods

            var c = a.Where(i => i > 0 && i < 12);
            
            return c;
        }
    }
}
