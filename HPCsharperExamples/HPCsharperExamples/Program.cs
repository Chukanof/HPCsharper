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
            // Parallel Merge Sort of Array example
            int[] arrayOne = { 21, 43, 16, 5, 54, 3 };
            int[] arrayTwo = { 21, 43, 16, 5, 54, 3 };

            arrayOne.SortMergePar();
            Array.Sort(arrayTwo);

            if (arrayOne.SequenceEqual(arrayTwo))
                Console.WriteLine("Sorted array results are equal");
            else
                Console.WriteLine("Sorted array results are not equal!");

            // Parallel Merge Sort of List example
            var listOne = new List<int>() { 15, 11, 34, 4, 25, 67 };
            var listTwo = new List<int>() { 15, 11, 34, 4, 25, 67 };

            ParallelAlgorithm.SortMergePar(ref listOne);
            //listOne = listOne.SortMergePar();             // another valid usage
            listTwo.Sort();

            if (listOne.SequenceEqual(listTwo))
                Console.WriteLine("Sorted List results are equal");
            else
                Console.WriteLine("Sorted List results are not equal!");

            // Measure Parallel Merge Sort of Array speedup
            SortMeasureArraySpeedup();
            // Measure Parallel Merge Sort of List speedup
            SortMeasureListSpeedup();
        }
    }
}
