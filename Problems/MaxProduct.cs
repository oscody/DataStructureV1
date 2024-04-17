using System;
namespace DataStructureV1.Problems
{
	public static class MaxProduct
	{
		public static void Solve1(int[] arr, int n) {

            if (n < 2)
            {
                Console.Write("No pairs exists");
                return;
            }

            // Initialize max product pair 
            int a = arr[0], b = arr[1];

            // Traverse through every possible pair 
            // and keep track of max product 
            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] * arr[j] > a * b)
                    {
                        a = arr[i];
                        b = arr[j];
                    }

            Console.Write("Max product pair is {" +
                               a + ", " + b + "}");


        }
	}
}

