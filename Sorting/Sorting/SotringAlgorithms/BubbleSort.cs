using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class BubbleSort : ISortingAlgorithm
    {
        public void Sort<T, K>(T elements, IComparer<K> comparer) 
            where T : IList<K>
        {
            for (int i = 0; i < elements.Count(); i++)
            {
                for (int j = i + 1; j < elements.Count(); j++)
                {
                    if (comparer.Compare(elements.ElementAt(j), elements.ElementAt(i)) == -1)
                    {
                        var temp = elements.ElementAt(i);
                        elements[i] = elements[j];
                        elements[j] = temp;
                    }
                }
            }
        }
    }
}
