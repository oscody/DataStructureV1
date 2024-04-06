using System;
namespace DataStructureV1
{
	public class RunningSumOf1DArray
	{
		public RunningSumOf1DArray()
		{
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

