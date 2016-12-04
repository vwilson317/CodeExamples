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
        public static int[] BubbleSort(this int[] array)
        {
            return array;
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
