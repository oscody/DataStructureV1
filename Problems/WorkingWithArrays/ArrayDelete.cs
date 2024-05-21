using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructureV1.Problems.WorkingWithArrays
{
    public static class ArrayDelete
    {
       public  static void Test(){

            //DeleteFromEnd();
            //DeleteFromStart();
            //DeleteFromAnywher();

            int [] nums = { 3, 2, 2, 3 };
            int val = 3;

            DeleteItemsFromArray(nums, val);
        }


        static void DeleteFromEnd(){
            int[] intArray = {0, 1, 2, 3, 4, 5};



            int length = 6;

            intArray[length - 1] = 0;
            length--;

            Helper.IntArrayToString(intArray);
        }


        static void DeleteFromStart() {

            int[] intArray = { 1, 2, 3, 4, 5 };



            int length = 5;

            for (int i = 1; i < length; i++)
            {
                // Shift each element one position to the left
                intArray[i - 1] = intArray[i];
            }

            // Note that it's important to reduce the length of the array by 1.
            // Otherwise, we'll lose consistency of the size. This length
            // variable is the only thing controlling where new elements might
            // get added.
            length--;


            Helper.IntArrayToString(intArray);

        }


        static void DeleteFromAnywher() {

            int[] intArray = { 1, 2, 3, 4};
            int length = 4;

            for (int i = 2; i < length; i++) {


                intArray[i - 1] = intArray[i];

            }

            length--;


            Helper.IntArrayToString(intArray);


        }



        static void DeleteItemsFromArray(int[] nums, int val) {

            var counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("i-"+i);

                if (nums[i] != val)
                {

                    nums[counter] = nums[i];
                    counter++;
                }
          

            }

            Console.WriteLine("Count-"+counter);


            Helper.IntArrayToString(nums);

        }


        public static void  RemoveDuplicates(int[] nums) {

            // If the array is empty, return 0
            if (nums.Length == 0) {
                Console.WriteLine("Empty array provided.");
                //return 0;
            }

            // Initialize the index for unique elements
            int k = 1; // Start from 1 because the first element is always unique

            // Iterate over the array starting from the second element
            for (int i = 1; i < nums.Length; i++) {
                // Check if the current element is different from the one before it
                if (nums[i] != nums[i - 1]) {
                    // Place the current element at the k-th position in the array
                    nums[k] = nums[i];
                    // Increment k
                    k++;
                }
            }

            // Print the resulting array up to k (for debugging purposes)
            Console.WriteLine($"The first {k} elements of the modified array are:");
            for (int i = 0; i < k; i++) {
                Console.Write(nums[i] + (i < k - 1 ? ", " : "\n"));
            }

            // Return the number of unique elements
            //return k;
            Console.Write("k-"+k);

        }

    }
}