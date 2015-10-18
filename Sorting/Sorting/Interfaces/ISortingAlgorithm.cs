using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface ISortingAlgorithm
    {
        T Sort<T, K>(T elements, IComparer<K> comparer)
            where T : ICollection<K>, new();
    }
}
