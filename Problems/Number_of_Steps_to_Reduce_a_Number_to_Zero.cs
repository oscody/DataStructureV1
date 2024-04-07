using System;
namespace DataStructureV1.Problems
{
	public class Number_of_Steps_to_Reduce_a_Number_to_Zero
	{
		public Number_of_Steps_to_Reduce_a_Number_to_Zero(int num)
		{
            NumberOfSteps(num);

        }


        public int NumberOfSteps(int num)
        {
			int count = 0;
            int remainder = 0;


            while (num > 0)
			{
                Console.WriteLine("loop Num-"+num);
                Console.WriteLine("loop remainder-" + remainder);

                if (num % 2 == 0)
                {

                    num = num / 2;
                    count++;
                    Console.WriteLine(num);

                }
                else {

                    num = num - 1;
                    count++;
                    Console.WriteLine(num);

                }

            }


            Console.WriteLine(count);
			return count;
        }
    }
}

