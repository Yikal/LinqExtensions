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

        public static int Mean(this IEnumerable<int> source)
        {
            var list = source.ToList();
            list.Sort();
            if(list.Count % 2 == 0)
            {
                return (int)Math.Round(
                    (list[(int)Math.Floor(list.Count / 2.0)] +
                    list[(int)Math.Ceiling(list.Count / 2.0)]) / 2.0
                    );
            }else
            {
                return list[list.Count / 2];
            }
        }
    }
}
