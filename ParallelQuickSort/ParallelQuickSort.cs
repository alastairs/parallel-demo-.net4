using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParallelQuickSort
{
    public class ParallelQuickSort
    {
        public IList<int> Numbers
        {
            get;
            set;
        }

        /// <summary>
        /// Sorts the array of numbers using a parallel quick sort implementation.
        /// </summary>
        public void Sort()
        {
            QuickSort(0, Numbers.Count - 1);
        }

        /// <summary>
        /// Actually does the sorting
        /// </summary>
        /// <param name="left">The lower bound index for the array segment</param>
        /// <param name="right">The upper bound index for the array segment</param>
        /// <returns>The list of numbers, sorted</returns>
        private IList<int> QuickSort(int left, int right)
        {
            if (right > left)
            {
                int pivot = left;
                int newPivot = Partition(left, right, pivot);

                // The two recursive calls to QuickSort work on separate sections
                // of the array of numbers, so these can be invoked in parallel
                Parallel.Invoke(delegate
                {
                    QuickSort(left, newPivot - 1).AsParallel();
                }, 

                delegate
                {
                    QuickSort(newPivot + 1, right).AsParallel();
                });
            }

            return Numbers;
        }

        /// <summary>
        /// Helper method to calculate the partition in the array of numbers.
        /// </summary>
        /// <param name="left">The lower bound index for the array segment</param>
        /// <param name="right">The upper bound index for the array segment</param>
        /// <param name="pivotIndex">The current index of the pivot</param>
        /// <returns>The new index of the pivot</returns>
        private int Partition(int left, int right, int pivotIndex)
        {
            int pivotValue = Numbers[pivotIndex];
            Numbers[pivotIndex] = Numbers[right];
            Numbers[right] = pivotValue;

            int storeIndex = left;
            int storeVal = Numbers[storeIndex]; 
            for (int i = left; i < right; i++)
            {
                if (Numbers[i] < pivotValue)
                {
                    Numbers[storeIndex] = Numbers[i];
                    Numbers[i] = storeVal;
                    ++storeIndex;
                }

                storeVal = Numbers[storeIndex];
                Numbers[storeIndex] = Numbers[right];
                Numbers[right] = storeVal;
            }

            return storeIndex;
        }
    }
}
