using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class QuickSort : ISortingAlgorithm
    {
        public void Sort<T, K>(T elements, IComparer<K> comparer) 
            where T : IList<K>
        {
             _QuickSort(elements, 0, elements.Count() - 1, comparer);

        }

        private void _QuickSort<K>(IList<K> list, int from, int to, IComparer<K> comparer)
        {
            int _from = from;
            int _to = to;
            K middleElement;

            if (to > from)
            {
                middleElement = list[(from + to) / 2];
                while (_from <= _to)
                {
                    while ((_from < to) && (comparer.Compare(list[_from],middleElement)) == -1)
                        ++_from;
                    while ((_to > from) && (comparer.Compare(list[_to], middleElement)) == 1)
                        --_to;
                    if (_from <= _to)
                    {
                        K T;
                        T = list[_from];
                        list[_from] = list[_to];
                        list[_to] = T;

                        ++_from;
                        --_to;
                    }
                }

                if (from < _to) _QuickSort(list, from, _to, comparer);
                if (_from < to) _QuickSort(list, _from, to, comparer);
            }
        }
    }
}
