using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructureV1.Problems.LeetCode
{
	public static class TwoSum
	{
        public static void Run()
        {

            var testOne = new int[] {3, 2, 4};
            var target = 6;
            //AttemptV1(testOne, target);
            SolutionV1(testOne, target);

        }


        public static int[] SolutionV1 (int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    Console.WriteLine("j-" + j);
                    Console.WriteLine("nums[j]-" + nums[j]);
                    Console.WriteLine("I-" + i);
                    Console.WriteLine("nums[i]-" + nums[i]);

                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }

            }

            return null;
        }

        //Bad because only find consecutive numbers
        private static int[] AttemptV1(int[] nums, int target)
        {

            int[] output = new int[2];
            Console.WriteLine("nums.Length-" + nums.Length);


            for (int i = 0; i < nums.Length - 1; i++)
            {
                Console.WriteLine("num[i]-" + nums[i]);
                Console.WriteLine("num[i + 1]-" + nums[i + 1]);

                if (nums[i] + nums[i + 1] == target)
                {

                    Console.WriteLine("Found Solution");

                    Console.WriteLine("found-" + nums[i]);
                    Console.WriteLine("found-" + nums[i + 1]);

                    output[0] = i;
                    output[1] = i + 1;

                }


            }

            Helper.ArrayToString(output);
            return output;
        }
    }
}

