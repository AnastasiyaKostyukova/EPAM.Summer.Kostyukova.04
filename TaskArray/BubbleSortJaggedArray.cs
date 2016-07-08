using System;

namespace TaskArray
{
    public class BubbleSortJaggedArray
    {
        /// <summary>
        /// There is sorting by increase sem of elements in lines of jagged array
        /// </summary>
        /// <param name="array">Jagged Array</param>
        /// <returns>Sorted Jagged Array</returns>
        public static int[][] BubbleSortIncreaseSumOfLineItems(int[][] array)
        {
            if (array.Length == 1 || array.Length == 1)
            {
                return array;
            }

            //if (array.Length == 0)     // !!! may be exception?
            //{
            //    throw new ArgumentException("array lenght is zero.");
            //}

            for (int n = array.Length - 1; n > 0; n--)
            {
                for (int i = 0; i < n; i++)
                {
                    long sumElementsOfCurrentLine = SumOfArrayElements(array, i);
                    long sumElementsOfNextLine = SumOfArrayElements(array, i + 1);

                    if (sumElementsOfCurrentLine > sumElementsOfNextLine)
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }

            return array;
        }

        public static int[][] BubbleSortDecreaseSumOfLineItems(int[][] array)
        {
            if (array.Length == 0 || array.Length == 1)
            {
                return array;
            }

            for (int n = array.Length - 1; n > 0; n--)
            {
                for (int i = 0; i < n; i++)
                {
                    long sumElementsOfCurrentLine = SumOfArrayElements(array, i);
                    long sumElementsOfNextLine = SumOfArrayElements(array, i + 1);

                    if (sumElementsOfCurrentLine < sumElementsOfNextLine)
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
            }

            return array;
        }

        private static long SumOfArrayElements(int[][] array, int i)
        {
            long sum = 0;
            for (int j = 0; j < array[i].Length; j++)
            {
                sum += array[i][j];
            }

            return sum;
        }






        private static void Swap(ref int[] firstArray, ref int[] secondArray)
        {
            int[] glass = firstArray;
            firstArray = secondArray;
            secondArray = glass;
        }




    }
}
