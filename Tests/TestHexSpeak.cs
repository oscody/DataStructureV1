namespace DataStructureV1.Tests
{

    public static class TestHexSpeak
    {
        /*
        Problem Statement:
        Write a function that, given a string S encoding a decimal integer N, returns a string representing
        the HexSpeak representation H of N if H is a valid HexSpeak word, or else "ERROR".
        HexSpeak words only use the letters ABCDEFIO, where '0' is replaced with 'O' and '1' with 'I'.

        A decimal number can be converted to HexSpeak by first converting it to hexadecimal (in upper case),
        then converting the number 0 to the letter 'O' and the number 1 to the letter 'I'.
        A string is considered a valid HexSpeak word if it consists only of the letters ABCDEFIO.

        Examples:
        Input: "257"
        Output: "IOI"  // Explanation: 257 in decimal is 101 in hexadecimal, which translates to IOI in HexSpeak.

        Input: "3"
        Output: "ERROR"  // Explanation: 3 in decimal is 3 in hexadecimal, which is not a valid HexSpeak character.
        */

        public static string SolutionV1(string S)
        {

            Console.WriteLine("S-" + S);

            // Convert string S to a long integer
            long number = Convert.ToInt64(S);

            Console.WriteLine("number-"+number);

            // Convert the number to uppercase hexadecimal
            string hex = number.ToString("X");
            Console.WriteLine("hex-" + hex);

            // Replace '0' with 'O' and '1' with 'I'
            hex = hex.Replace('0', 'O').Replace('1', 'I');
            Console.WriteLine("hex-Replace-" + hex);

            // Check if the hexadecimal string contains invalid characters
            if (hex.Any(c => !"ABCDEFIO".Contains(c)))
            {
                return "ERROR";
            }

            return hex;
        }

        // Example Usage
        public static void Run()
        {
            Console.WriteLine(SolutionV1("257"));  // Expected Output: "IOI"
            Console.WriteLine(SolutionV1("3"));    // Expected Output: "ERROR"
        }
    }

}

