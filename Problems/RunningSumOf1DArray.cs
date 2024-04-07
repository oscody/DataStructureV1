using System;
namespace DataStructureV1
{
	public class RunningSumOf1DArray
	{
		public RunningSumOf1DArray()
		{
            Console.WriteLine("Running Sum Of 1D Array V1");

            var testRunningSumOf1DArray = new RunningSumOf1DArray();

            int[] input = new[] { 1, 2, 3, 4 };

            var resultv1 = testRunningSumOf1DArray.RunningSumOf1DArrayV1(input);

            var resultString = string.Join(", ", resultv1);
            Console.WriteLine(resultString);


            Console.WriteLine("Running Sum Of 1D Array V2");

            var resultv2 = testRunningSumOf1DArray.RunningSumOf1DArrayV2(input);

            var resultV2String = string.Join(", ", resultv2);
            Console.WriteLine(resultV2String);
        }

        public int[] RunningSumOf1DArrayV1(int[] input) {

            int[] total = new int[input.Length];


            for (var i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    // The first element of total is the same as the first element of input
                    total[i] = input[i];
                }
                else
                {
                    // Add the current element of input to the last total's value
                    total[i] = total[i - 1] + input[i];
                }
            }

            //for (var i = 0; i < total.Length; i++)
            //{

            //    Console.WriteLine(total[i]);

            //}



            return total;

        }


        public int[] RunningSumOf1DArrayV2(int[] input)
        {

            for (int i = 1; i < input.Length; i++)
            {

                input[i] +=input[i - 1];

            }

            return input;

        }

    }
}

