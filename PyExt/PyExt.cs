using NumSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PyExt
{
    public static class PyExt
    {
        public static IEnumerable<T> sorted<T>(params T[] objs)
        {
            return objs.OrderBy(x => x).ToArray();
        }
        public static IEnumerable<T> set<T>(T[] objs)
        {
            return objs.Distinct();
        }
        public static IEnumerable<int> set(params int[] objs)
        {
            return objs.Distinct();
        }
        public static string str(object o)
        {
            var str = "";
            foreach (var p in o.GetType().GetProperties())
            {
                str += p.GetValue(o, null).ToString();
            }
            return str;
        }
        public static IEnumerable<(int, T)> enumerate<T>(IEnumerable<T> obj)
        {
            return obj.Select((i, x) => (x, i)).ToList();
        }
        public static int len<T>(T obj)
        {
            foreach (var p in obj.GetType().GetProperties())
            {
                if (p.Name == "Count")
                    return int.Parse(p.GetValue(obj, null).ToString());
                if (p.Name == "Length")
                    return int.Parse(p.GetValue(obj, null).ToString());
                if(p.Name == "size")
                    return int.Parse(p.GetValue(obj, null).ToString());
            }
            return 0;

        }

        public static int integer(object o)
        {
            return int.Parse(o.ToString());
        }
    }
}
