using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            for(int i = 0; i < 10000; i++)
            {
                list.Add(random.Next());
            }

           Console.WriteLine("Quick sort-> ");
           SortList(list, new QuickSort());
           Console.WriteLine("Shaker sort-> ");
           SortList(list, new ShakerSort());
           Console.WriteLine("Bubble sort-> ");
           SortList(list, new BubbleSort());

           Console.Read();
           
        }

        static void SortList(List<int> list, ISortingAlgorithm sortingAlgorithm)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            sortingAlgorithm.Sort<List<int>, int>(list, Comparer<int>.Default);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime + "\n");
        }
    }
}
