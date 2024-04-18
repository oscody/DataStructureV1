using System;
namespace DataStructureV1.Problems
{
	public static class MaxProduct
	{

        public static void Test()
        {
            var problem = "Max Product";

            var together = problem.Replace(" ", "_");

            Console.WriteLine(together);

            int[] arr = { 1, 4, 3, 6, 7, 0 };
            int n = arr.Length;
            MaxProduct.Solve1(arr, n);
        }


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


        public static int MaximumProduct(int[] nums)
        {
            // 628. Maximum Product of Three Numbers
            // https://leetcode.com/problems/maximum-product-of-three-numbers/


            Array.Sort(nums);
            var n = nums.Length;



            int a = nums[n - 1] * nums[n - 2] * nums[n - 3];
            int b = nums[0] * nums[1] * nums[2];

            if (a > b)
            {

                //Console.Write(a);
                return a;

            }
            else
            {

                //Console.Write(b);
                return b;
            }

        }
    }
}

