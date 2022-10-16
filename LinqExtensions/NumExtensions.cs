using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtensions
{
    public static class NumExtensions
    {
        public static IEnumerable<int> DuplicateInts(this IEnumerable<int> source)
        {
            var result = new List<int>();
            result.AddRange(source.GroupBy(s => s).Where(g => g.Count() > 1).Select(g => g.First()));
            return result;
        }

        public static double Mean(this IEnumerable<int> source)
        {
            var list = source.ToList();
            list.Sort();
            if(list.Count % 2 == 0)
            {
                return (list[list.Count / 2-1] + list[list.Count / 2]) / 2.0;
            }else
            {
                return list[list.Count / 2];
            }
        }

        public static IEnumerable<double> MultipyWithFactor(this IEnumerable<int> source, double factor)
        {
            var result = new List<double>();
            result.AddRange(source.Select(i => i * factor));
            return result;
        }
    }
}
