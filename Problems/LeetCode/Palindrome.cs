namespace DataStructureV1.Problems.LeetCode
{
    public static class Palindrome
    {
        public static void Run()
        {

            var test = 121;
            SolutionV1(test);
            test = -121;
            SolutionV1(test);
            test = 10;
            SolutionV1(test);

        }


        public static void SolutionV1 (int target)
        {

            string intAsAString = target.ToString();

            var seperate = intAsAString.ToArray();

            var reverse = seperate.Reverse();

            var intAsAStringReversed = string.Join("", reverse);

            Console.WriteLine($"Join={intAsAStringReversed}");


            if (intAsAStringReversed == intAsAString)
            {
                Console.WriteLine($"true");

            }
            else
            {
                Console.WriteLine($"false");


            }


        }

    }
}

