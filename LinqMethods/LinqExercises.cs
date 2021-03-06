﻿using System;
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

            // By extension method

            var c = a.Where(i => i > 0 && i < 12);

            return c;
        }

        //  Exercisese 2
        //    Write a program in C# Sharp to find the number of an array 
        //    and the square of each number which is more than 20.

        public static dynamic NumberSquare(IEnumerable<int> a)
        {
            var sqNo = from int Number in a
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select new { Number, SqrNo };

            // By extension methods

            var b = a.Where(i => i * i > 20).Select(j => new { Number=j, square = j * j });

            return b;
        }
         
         //  Exercisese 3
         //    Write a program in C# Sharp to display the
         //    number and frequency of number from giving array.

        public static IEnumerable<IGrouping<int,int>> Groupitem(IEnumerable<int> a)
        {
            var n = from x in a
                    group x by x into y
                    select y;
            // or
            var m = from x in a
                    group x by x;

            // By extension methods

            var b = a.GroupBy(x => x);

            return b;

        }

        //  Exercisese 4
        //     Write a program in C# Sharp to find the string
        //     which starts and ends with a specific character.

        public static IEnumerable<string> StartEndString(IEnumerable<string> a,char start,char end)
        {

            var result = from x in a
                          where x.StartsWith(start.ToString())
                          where x.EndsWith(end.ToString())
                          select x;

            // By extension methods

            var c = a.Where(x => x.StartsWith(start.ToString()) && x.EndsWith(end.ToString()));
            return c;
        }
    }
}
