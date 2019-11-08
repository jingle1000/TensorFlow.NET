using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tensorflow.Extensions
{
    public static class pyext
    {
        public static IEnumerable<(int, TGeneralized)> enumerate<TGeneralized>
        (this IEnumerable<TGeneralized> array) => array.Select((item, index) => (index, item));

        public static List<object> sorted(object[] objs)
        {
            return objs.Select(x => new { I = int.Parse(x.ToString()), o = x })
                .OrderBy(x => x.I)
                .Select(x => x.o)
                .ToList();
        }
    }
}
