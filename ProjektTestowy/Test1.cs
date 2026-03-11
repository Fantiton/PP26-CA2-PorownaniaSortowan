using PP26_CA2_PorownaniaSortowan;
using System.Diagnostics;

namespace ProjektTestowy
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Sorter sorter = new Sorter();   
            int[] inArray = { 5, 4, 4, 2, 2, 2, 1, 9, 8, 7, 6 };
            
            Stopwatch stopwatch = Stopwatch.StartNew();
            int[] sortedArray = sorter.BubbleSort(inArray);
            stopwatch.Stop();
            double elapsedTime = stopwatch.Elapsed.TotalNanoseconds;

            Console.WriteLine("Bubble sort: " + elapsedTime);

            stopwatch.Restart();
            sortedArray = sorter.SelectionSort(inArray);
            stopwatch.Stop();
            elapsedTime = stopwatch.Elapsed.TotalNanoseconds;
            Console.WriteLine("Selection sort: " + elapsedTime);

            stopwatch.Restart();
            sortedArray = sorter.QuickSort(inArray);
            stopwatch.Stop();
            elapsedTime = stopwatch.Elapsed.TotalNanoseconds;
            Console.WriteLine("Quick sort: " + elapsedTime);

            stopwatch.Stop();
        }
    }
}
