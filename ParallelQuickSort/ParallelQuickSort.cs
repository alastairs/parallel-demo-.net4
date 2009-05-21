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

        public void Sort()
        {
            QuickSort(0, Numbers.Count - 1);
        }

        private IList<int> QuickSort(int left, int right)
        {
            if (right > left)
            {
                int pivot = left;
                int newPivot = Partition(left, right, pivot);
                QuickSort(left, newPivot - 1).AsParallel();
                QuickSort(newPivot + 1, right).AsParallel();
            }

            return Numbers;
        }

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
