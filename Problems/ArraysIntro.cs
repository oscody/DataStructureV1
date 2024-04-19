using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructureV1.Problems
{
	public static class ArraysIntro
	{
        public static void TestCode() {

            int[] list = { 1, 1, 0, 1, 1, 1 };
            ///FindMaxConsecutiveOnes(list);

            int[] evenList = { 555, 901, 482, 1771 };
            //Console.WriteLine($"FindNumbers-{FindNumbers(evenList)}");

            int[] nonSorted = { -4, -1, 0, 3, 10 };
            //Console.WriteLine($"SortedSquares-{SortedSquares(nonSorted)}");


        }

        public static int[] SortedSquares(int[] nums)
        {

            // Initialize the array with the same length as nums
            int[] squaredArray = new int[nums.Length];  

            var squaredNumber = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                squaredNumber = nums[i] * nums[i];
                Console.WriteLine($"squaredNumber-{squaredNumber}");

                squaredArray[i] = squaredNumber;
            }


            // Sort the squared array
            Array.Sort(squaredArray);  

            string output = string.Join(" ", squaredArray);
            Console.WriteLine($"SortedSquares-{output}");

            return squaredArray;
        }

        private static int FindMaxConsecutiveOnes(int[] nums)
        {

            int currentConsecutive = 0;
            int maxConsecutive = 0;


            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 1)
                {

                    currentConsecutive++;

                }
                else
                {

                    currentConsecutive = 0;
                }

                maxConsecutive = Math.Max(maxConsecutive, currentConsecutive);
                Console.WriteLine($"{nums[i]}-{i}-currentConsecutive-{currentConsecutive},maxConsecutive-{maxConsecutive}");

            }

            Console.WriteLine("total=" + maxConsecutive);
            return maxConsecutive;
        }


        public static int FindNumbers(int[] nums)
        {

            var totalEvenDigits = 0;

            for (int i = 0; i < nums.Length; i++) {

                // Convert number to string and check its length
                int digitCount = nums[i].ToString().Length;

                // Check if the number of digits is even
                if (digitCount % 2 == 0)
                {
                    totalEvenDigits++;
                }

            }


            return totalEvenDigits;
        }
    }
}

