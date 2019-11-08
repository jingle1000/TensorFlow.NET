using System;
using System.Collections.Generic;
using System.Linq;

namespace PyExt
{
    public class pyx
    {
        public static int len<T>(IEnumerable<T> o)
        {
            return o.Count();
        }
        public static string str(object o)
        {
            var props = o.GetType().GetProperties();
            var retval = "";
            foreach(var p in props)
            {
                retval += p.GetValue(o, null).ToString();
            }
            return retval;
        }
        public static IEnumerable<(int, T)> enumerate<T>(IEnumerable<T> o)
        {
            return o.Select((x, i) => (i, x));
        }
        public static IEnumerable<T> sorted<T>(IEnumerable<T> o)
        {
            return o.OrderBy(x => x);
        }
    }
}
