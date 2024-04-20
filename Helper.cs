using System;
namespace DataStructureV1.Problems
{
	public static class Helper
	{

		public static void Test() {


            var problem = "Ransom Note";

            var together = problem.Replace(" ", "_");

            Console.WriteLine(together);


        }

        public static void ArrayToString(int[] a) {

            string output = string.Join(" ", a);
            Console.WriteLine($"ArrayToString-{output}");
        }
	}
}

