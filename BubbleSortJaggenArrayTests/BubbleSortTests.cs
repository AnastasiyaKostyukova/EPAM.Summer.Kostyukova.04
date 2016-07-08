using NUnit.Framework;
using System.Collections;
using TaskArray;

namespace BubbleSortJaggenArrayTests
{
    public class BubbleSortTests
    {
        #region test BubbleSortIncreaseSumOfLineItems Method
        [Test, TestCaseSource(typeof(ArraysDataProvider),
            nameof(ArraysDataProvider.ValidArraysForIncreaseSortByElementSumTestCases))]
        public void BubbleSortIncreaseSumOfLineItems_SortingJaggedArray_CorrectSortedArray(int[][] notSortArr, int[][] expectedArr)
        {
            var resultOfSorting = BubbleSortJaggedArray.BubbleSortIncreaseSumOfLineItems(notSortArr);
            // assert
            Assert.IsTrue(AreEqualJaggedArrays(resultOfSorting, expectedArr));
        }
        #endregion


        private bool AreEqualJaggedArrays(int[][] firstArr, int[][] secondArr)
        {

            if (firstArr.Length != secondArr.Length)
            {
                return false;
            }

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i].Length != secondArr[i].Length)
                {
                    return false;
                }
            }

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < firstArr[i].Length; j++)
                {
                    if (firstArr[i][j] != secondArr[i][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        public class ArraysDataProvider
        {
            public static IEnumerable ValidArraysForIncreaseSortByElementSumTestCases
            {
                get
                {
                    yield return new TestCaseData(
                    new[]
                    {
                        new[] {1, 3, 5, 7, 9}, // 25
                        new[] {6, 6, 8}, // 20
                        new[] { 2, 4, 6, 8, 1, 0 }, // 21
                        new[] { 2, -4 } // -2
                    },
                    new[]
                    {
                        new[] { 2, -4 }, // -2
                        new[] {6, 6, 8}, // 20
                        new[] { 2, 4, 6, 8, 1, 0 }, // 21
                        new[] {1, 3, 5, 7, 9} // 25
                    });

                    yield return new TestCaseData(new[]
                    {
                        new[] {int.MaxValue, int.MaxValue, 1},
                        new[] {int.MaxValue, int.MaxValue, int.MaxValue, 0},
                        new[] {3, 2, 1, 0}
                    }, new[]
                    {
                        new[] {3, 2, 1, 0},
                        new[] {int.MaxValue, int.MaxValue, 1},
                        new[] {int.MaxValue, int.MaxValue, int.MaxValue, 0}
                    });

                    yield return new TestCaseData(new[]
                    {
                        new[] {0, int.MinValue, -1, -3},
                        new[] {-3, 0},
                        new[] {-5, -4, -3, -2}
                    }, new[]
                    {
                        new[] {0, int.MinValue, -1, -3},
                        new[] {-5, -4, -3, -2},
                        new[] {-3, 0}
                    });

                    yield return new TestCaseData(new[]
                    {
                        new[] {0, 0},
                        new[] {0, 0, 0}
                    }, new[]
                    {
                        new[] {0, 0},
                        new[] {0, 0, 0}
                    });

                    yield return new TestCaseData(new[]
                    {
                        new[] {int.MinValue, 0},
                        new[] {0, 0, 0}
                    }, new[]
                    {
                        new[] {int.MinValue, 0},
                        new[] {0, 0, 0}
                    });

                    yield return new TestCaseData(new int[][]
                    {
                    }, new int[][]
                    {
                    });

                    yield return new TestCaseData(new[]
                    {
                        new[] {3, 10, 1}
                    }, new[]
                    {
                        new[] { 3, 10, 1 }
                    });
                }
            }
        }
    }
}