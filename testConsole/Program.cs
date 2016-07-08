using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskArray;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[0][];

            arr[0] = new int[] { 1, 3, 5, 7, 9 }; // 25
            arr[1] = new int[] { 2, 4, 6, 8 }; // sum 20
            arr[2] = new int[] { 2, 4, 6, 8, 1 }; // sum 21
            arr[3] = new int[] { 2, 4, 6 }; // sum 12

            //AscendingSortByStringElementsSum(arr);

            var r = BubbleSortJaggedArray.BubbleSortIncreaseSumOfLineItems(arr);
            for (int i = 0; i < r.Length; i++)
            {
                for (int j = 0; j < r[i].Length; j++)
                {
                    Console.Write(" {0}", r[i][j]);
                }
                Console.WriteLine(string.Empty);                 
            }

            var r2 = BubbleSortJaggedArray.BubbleSortDecreaseSumOfLineItems(arr);
            for (int i = 0; i < r2.Length; i++)
            {
                for (int j = 0; j < r2[i].Length; j++)
                {
                    Console.Write(" {0}", r2[i][j]);
                }
                Console.WriteLine(string.Empty);
            }
        }

        


        public static void AscendingSortByStringElementsSum(int[][] array)
        {
            if (array.Length == 1)
                Console.WriteLine("Leng of arr is 0");
        }
    }
}
