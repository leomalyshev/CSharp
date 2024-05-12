using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    public static class MyExtension
    {
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> collections, Predicate<T> predicate)
        {
            foreach (var item in collections)
            {
                if (predicate(item)) yield return item;
            }
        }
    }
}
