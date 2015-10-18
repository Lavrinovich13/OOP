using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class ShakerSort : ISortingAlgorithm
    {
        public T Sort<T, K>(T elements, IComparer<K> comparer) where T : ICollection<K>, new()
        {
            T newEl = new T();

            var list = elements.ToList();

            int from, to;
            for (int i = 0; i < list.Count() / 2; i++)
            {
                from = 0;
                to = list.Count() - 1;
                do
                {
                    if (comparer.Compare(list[from],list[from + 1]) == 1)
                    {
                        var temp = list.ElementAt(from);
                        list[from] = list[from + 1];
                        list[from + 1] = temp;
                    }
                    from++;

                    if (comparer.Compare(list[to - 1], list[to]) == 1)
                    {
                        var temp = list.ElementAt(to - 1);
                        list[to - 1] = list[to];
                        list[to] = temp;
                    }
                    to--;
                }
                while (from <= to);
            }

            foreach (var item in list)
            {
                newEl.Add(item);
            }
            return newEl;
        }
    }
}
