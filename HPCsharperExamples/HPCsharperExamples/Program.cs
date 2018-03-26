using System;
using System.Collections.Generic;
using System.Linq;
using HPCsharp;
using HPCsharper;

namespace HPCsharperExamples
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Test Parallel Merge Sort
            uint[] arrayOne = { 21, 43, 16, 5, 54, 3 };
            uint[] arrayTwo = { 21, 43, 16, 5, 54, 3 };

            arrayOne.SortMergePar();
            Array.Sort(arrayTwo);

            bool equalSortedArrays = arrayOne.SequenceEqual(arrayTwo);

            if (equalSortedArrays)
                Console.WriteLine("Sorted results are equal");
            else
                Console.WriteLine("Sorted results are not equal!");

            // Measure Parallel Merge Sort of Array speedup
            SortMeasureArraySpeedup();
            // Measure Parallel Merge Sort of List speedup
            SortMeasureListSpeedup();
        }
    }
}
