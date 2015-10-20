using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class ShakerSort : ISortingAlgorithm
    {
        public void Sort<T, K>(T elements, IComparer<K> comparer) 
            where T : IList<K>
        {
            int from, to;
            for (int i = 0; i < elements.Count() / 2; i++)
            {
                from = 0;
                to = elements.Count() - 1;
                do
                {
                    if (comparer.Compare(elements[from],elements[from + 1]) == 1)
                    {
                        var temp = elements.ElementAt(from);
                        elements[from] = elements[from + 1];
                        elements[from + 1] = temp;
                    }
                    from++;

                    if (comparer.Compare(elements[to - 1], elements[to]) == 1)
                    {
                        var temp = elements.ElementAt(to - 1);
                        elements[to - 1] = elements[to];
                        elements[to] = temp;
                    }
                    to--;
                }
                while (from <= to);
            }
        }
    }
}
