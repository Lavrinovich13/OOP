using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSort : ISortingAlgorithm
    {
        public T Sort<T, K>(T elements, IComparer<K> comparer) 
            where T : ICollection<K>, new()
        {
            T newEl = new T();

            var list = elements.ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                for (int j = i + 1; j < list.Count(); j++)
                {
                    if (comparer.Compare(list.ElementAt(j), list.ElementAt(i)) == -1)
                    {
                        var temp = list.ElementAt(i);
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }

            foreach(var item in list)
            {
                newEl.Add(item);
            }
            return newEl;
        }
    }
}
