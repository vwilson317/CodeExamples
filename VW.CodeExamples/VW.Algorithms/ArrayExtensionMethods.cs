using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VW.Algorithms
{
    public static class ArrayExtensionMethods
    {
        public static int[] InsertionSort(this int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                InsertionSortSwap(array, i);
            }
            return array;
        }

        private static void InsertionSortSwap(int[] array, int sortedIndexDivider)
        {
            
            for (int i = 0; i < sortedIndexDivider; i++)
            {
                if (i == sortedIndexDivider)
                {
                    break;
                }

                var currentVal = array[i];
                var swapVal = array[sortedIndexDivider];
                if (array[i] > array[sortedIndexDivider])
                {
                    array[i] = swapVal;
                    array[sortedIndexDivider] = currentVal;
                }
            }
        }


        /// <summary>
        /// o(n^2) runtime
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] BubbleSort(this int[] array)
        {
            var endIndex = array.Length;
            var loopIndex = 0;
            while (loopIndex < endIndex)
            {

                SwapItems(array, loopIndex);
                loopIndex++;
            }

            return array;
        }

        private static void SwapItems(int[] array, int leftIndex)
        {
            //don't traverse go the full length of the array
            for (var currentItemIndex = leftIndex; currentItemIndex < array.Length -1; currentItemIndex++)
            {
                var nextItemIndex = currentItemIndex + 1;
                var nextItemVal = array[nextItemIndex];
                var currentItemVal = array[currentItemIndex];
                if (nextItemVal < currentItemVal)
                {
                    array[currentItemIndex] = nextItemVal;
                    array[nextItemIndex] = currentItemVal;
                }
            }
        }

        /// <summary>
        /// n log n sorting algorithm 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] QuickSort(this int[] array)
        {
            var middleIndex = (int) Math.Round((double) (array.Length/2));
            QuickSort(array, 0, array.Length -1);
            return null;
        }

        private static void QuickSort(int[] array, int start, int end)
        {
            if (start < end)
            {
                var splitIndex = Partition(array, start, end);
                QuickSort(array, splitIndex + 1, end);
                QuickSort(array, start, splitIndex -1);
            }
        }

        private static int Partition(int[] array, int partitionIndex, int endIndex)
        {
            var endValue = array[endIndex];
            var comparisonValueIndex = partitionIndex;
            while (comparisonValueIndex < endIndex)
            {
                var comparisonValue = array[comparisonValueIndex];
                if (comparisonValue < endValue)
                {
                    var partitionValue = array[partitionIndex];
                    //swap values
                    array[partitionIndex] = comparisonValue;
                    array[comparisonValueIndex] = partitionValue;
                    partitionIndex++;
                }

                comparisonValueIndex++;
            }

            //Swap last element
            array[endIndex] = array[partitionIndex];
            array[partitionIndex] = endValue;

            return partitionIndex;
        }
    }
}
