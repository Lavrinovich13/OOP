using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface ISortingAlgorithm
    {
        void Sort<T, K>(T elements, IComparer<K> comparer)
            where T : IList<K>;
    }
}
