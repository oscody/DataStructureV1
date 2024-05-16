using System.Text;

public class HelloWorld
{

    static string ReverseEachWord(String input)
    {
        if (String.IsNullOrEmpty(input)) {
            return input;
        }

        StringBuilder result = new StringBuilder();
        string[] arr = input.Split(" ");

        for (int i = 0; i < arr.Length; i++) {
            result.Append(Reverse(arr[i]));
            if (i != arr.Length -1) {
                result.Append(" ");
            }
        }

        return result.ToString();
    }


    static String Reverse(String input)
    {

        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        StringBuilder reversed = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }


    static void Main(string[] args)
    {
        Console.WriteLine(ReverseEachWord("sally is a great worker"));
        Console.WriteLine(ReverseEachWord(null));
        Console.WriteLine(ReverseEachWord("racer racecar madam"));
        Console.WriteLine(ReverseEachWord("what can I do today"));
        Console.WriteLine(ReverseEachWord(" "));
    }

}