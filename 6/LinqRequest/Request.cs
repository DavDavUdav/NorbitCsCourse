using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRequest
{
    class Request
    {
        public static IEnumerable<int> Filter(int[] array)
        {
            var query1 = from i in array
                         where i % 2 == 1
                         select i;

            return query1;
        } 
    }
}
