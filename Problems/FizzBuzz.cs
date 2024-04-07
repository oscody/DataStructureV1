using System;
namespace DataStructureV1.Problems
{
	public class FizzBuzz
	{
		public FizzBuzz(int n)
		{
            SolutionV1(n);
        }

        private IList<string> SolutionV1 (int n)
        {
            
            var answer = new List<string> { };

            for (int i = 1; i <= n; i++) {

                Console.WriteLine("The n-" + i);

                if ((i % 3 == 0) & (i % 5 == 0))
                {
                    answer.Add("FizzBuzz");

                }
                else if (i % 3 == 0)
                {

                    answer.Add("Fizz");

                }
                else if (i % 5 == 0)
                {

                    answer.Add("Buzz");

                }
                else {

                    var valuet = Convert.ToString(i);
                    answer.Add(valuet);

                }

            }


            string output = string.Join(" ", answer);
            Console.WriteLine(output);
            return answer;
        }

    }
}

