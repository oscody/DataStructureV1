using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructureV1.Problems
{
	public static class ArraySearching
	{
        public static void TestCode() {

            CheckIfNAndItsDoubleExist()

        }


        static void CheckIfNAndItsDoubleExist(int[] arr) {
            
                            // Use a HashSet to store the elements for quick lookup
            HashSet<int> set = new HashSet<int>();

            foreach (var num in arr)
            {
                // Log the current number being processed
                Console.WriteLine($"Processing number: {num}");

                // Check if the double of current number or half of it (if it is even) exists in the set
                if (set.Contains(2 * num))
                {
                    Console.WriteLine($"Found: {num} * 2 = {2 * num} exists in the set.");
                    return true; // If found, return true
                }
                if (num % 2 == 0 && set.Contains(num / 2))
                {
                    Console.WriteLine($"Found: {num} / 2 = {num / 2} exists in the set.");
                    ///return true; // If found, return true
                    Console.WriteLine($"true");

                }

                // Add the current number to the set
                set.Add(num);
                // Log the current state of the HashSet
                Console.WriteLine($"HashSet contents: {string.Join(", ", set)}");
            }

            // If no such pair is found, return false
            Console.WriteLine($"false");


        }

    }
}

