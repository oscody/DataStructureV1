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


         static Boolean PalindromeChecker(string original)
    {
        string normalized = original.ToLower();
        string reversed = "";

        for (int i = normalized.Length - 1; i >= 0; i--)
        {
            reversed = reversed + normalized[i];
        }

        return normalized.Equals(reversed);
    }

    static Boolean PalindromeChecker2(string original) {
        string normalized = original.ToLower();
        int length = normalized.Length;

        for (int i = 0; i < length / 2; i++) {
            if (normalized[i] != normalized[length-1-i]) {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        string s1 = "madam";
        string s2 = "racecar";
        string s3 = "abba";
        string s4 = "swims";
        string s5 = "wifi";

        Console.WriteLine(PalindromeChecker(s1));
        Console.WriteLine(PalindromeChecker(s2));
        Console.WriteLine(PalindromeChecker(s3));
        Console.WriteLine(PalindromeChecker(s4));
        Console.WriteLine(PalindromeChecker(s5));
    }

    }
}

