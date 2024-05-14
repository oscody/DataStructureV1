using System;
namespace DataStructureV1.Problems.WorkingWithArrays
{
	public static class ArraysInsert
	{

        public static void TestCode()
        {

            int[] findZero = { 1, 0, 2, 3, 0, 4, 5, 0 };
            //DuplicateZeros(findZero);

            //InsertAtEnd();
            //InsertAtStart();
            //InsertAnyWhere();

            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int m = 3, n = 3;

            //MergeSortedArray(nums1, m, nums2, n);
            MergeExplained(nums1, m, nums2, n);
        }



        static void InsertAtEnd()
        {
            int[] intArray = new int [6];

            int length = 0;

            for (int i = 0; i < 3; i++)
            {
                intArray[i] = i;
                Console.WriteLine(intArray[i]);
                length++;
            }

            intArray[length] = 10;
            length++;

            //Helper.IntArrayToString(intArray);
            
        }
        static void InsertAtStart(){

            int[] intArray = {0, 1, 2, 10, 0,0};

            for(int i = 3; i >= 0; i--){
                intArray[i + 1] = intArray[i];
            }

            intArray[0] = 20;

            Helper.IntArrayToString(intArray);

        }
        static void InsertAnyWhere(){

            int[] intArray = {20,0, 1, 2, 10, 0};


            for (int i = 4; i >= 2; i--)
            {
                // Shift each element one position to the right.
                intArray[i + 1] = intArray[i];
            }

            // Now that we have created space for the new element,
            // we can insert it at the required index.
            intArray[2] = 30;

            Helper.IntArrayToString(intArray);

        }

        public static void MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {

            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            // Merge nums2 into nums1 starting from the end
            while (i >= 0 && j >= 0) {

                if (nums1[i] > nums2[j]) {

                    nums1[k--] = nums1[i--];

                } else {

                    nums1[k--] = nums2[j--];
                }
            }

            // Fill nums1 with remaining nums2 elements if any
            while (j >= 0) {
                nums1[k--] = nums2[j--];
            }

        }

        public static void MergeExplained(int[] nums1, int m, int[] nums2, int n) {



            // Starting Position: Identify the end where the combined elements will be placed.
            int i = m - 1; // Last child in the first line (tallest not yet placed in nums1).
            int j = n - 1; // Last child in the second line (tallest not yet placed in nums2).
            int k = m + n - 1; // The end of the combined line.

            // Print initial state of arrays
            Console.WriteLine("Initial nums1: " + string.Join(", ", nums1));
            Console.WriteLine("Initial nums2: " + string.Join(", ", nums2));

            // Repeat the Process: Compare the tallest children not yet placed and move the tallest.
            while (i >= 0 && j >= 0) {

                Console.WriteLine("Initial i: " + i);
                Console.WriteLine("Initial j: " + j);
                Console.WriteLine("Initial k: " + k);


                Console.WriteLine("nums1[i]: " + nums1[i]);
                Console.WriteLine("nums2[j]: " + nums2[j]);
                // Selecting the Tallest: Compare the last children in nums1 and nums2.
                if (nums1[i] > nums2[j]) {
                    // The child in nums1 is taller, move this child to the end of the combined line.
                    nums1[k] = nums1[i];
                    Console.WriteLine($"if Moving {nums1[i]} from nums1[{i}] to nums1[{k}]");
                    i--; // Move the pointer in nums1 back.
                } else {
                    // The child in nums2 is taller, move this child to the end of the combined line.
                    nums1[k] = nums2[j];
                    Console.WriteLine($"else Moving {nums2[j]} from nums2[{j}] to nums1[{k}]");
                    j--; // Move the pointer in nums2 back.
                }
                k--; // Move the end pointer of the combined line back.
            }

            // Fill in the Remaining Children: If any children left in nums2 after nums1 is empty.
            while (j >= 0) {
                // The remaining children in nums2 are moved directly to the combined line.
                nums1[k] = nums2[j];
                Console.WriteLine($"Moving remaining {nums2[j]} from nums2[{j}] to nums1[{k}]");
                j--;
                k--;
            }

            // Final state of the combined array
            Console.WriteLine("Final nums1: " + string.Join(", ", nums1));
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

