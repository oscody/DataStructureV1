using System;
namespace DataStructureV1.Problems.WorkingWithArrays
{
	public static class ArraysInsert
	{

        public static void TestCode()
        {

            int[] findZero = { 1, 0, 2, 3, 0, 4, 5, 0 };
            //DuplicateZeros(findZero);
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

        }

        public static void DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    for (int j = arr.Length - 1; j > i; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    if (i + 1 < arr.Length)
                    {
                        arr[i + 1] = 0;
                    }
                    i++; // Skip the next zero we just added
                }
            }

            Helper.ArrayToString(arr);

        }
    }
}

