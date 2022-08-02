using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 2, 4, 5, 1, 0, 7, 89, 54, 3, 99 };

            var q1 = Request.Filter(array);

            foreach (var i in q1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
