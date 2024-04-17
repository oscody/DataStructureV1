using System;
using System.Text;

namespace DataStructureV1.DataStructures
{
	public class Strings
	{
		public Strings()
		{
			//StringBuilderExample();


			reverseString("test");

        }


		private void StringBuilderExample() {


			string firstName = "Shelly";
			string lastName = "Parker";


			string name = firstName + " " + lastName;



			StringBuilder stringBuilder = new StringBuilder();

			stringBuilder.Append("def");
			stringBuilder.Append("ghi");
			stringBuilder.Insert(0, "xyz");
			stringBuilder.Remove(3, 6);

			string alpha = stringBuilder.ToString();

			Console.WriteLine(alpha);


			Console.WriteLine(Search_For_A_Letter(" This is about Strings,"));

			TestValidation();


        }



		private string Search_For_A_Letter(String input) {


			//Convert to 1 form uppercase or lowercase 

			string lowerCase = input.ToLower();
			string trim = lowerCase.Trim();
			string normalized = trim.Replace(",", "");

			return input.ToLower().Trim().Replace(",","");
		}


		private void TestValidation() {


            Console.WriteLine(isLowerCase("HellO"));
            Console.WriteLine(isLowerCase("hello"));

            Console.WriteLine(isUpperCase("hello"));
            Console.WriteLine(isUpperCase("HELLO"));

            Console.WriteLine(isPasswordComplex("HELLo1"));
            Console.WriteLine(isPasswordComplex("HELLO"));
        }

        private Boolean isUpperCase(string s)
		{
			return s.All(char.IsUpper);
		}

        private Boolean isLowerCase(string s)
        {
            return s.All(char.IsLower);

        }

        private Boolean isPasswordComplex(string input)
        {
			return input.Any(char.IsLower)
				&& input.Any(char.IsUpper)
				&& input.Any(char.IsDigit);

        }


		private string reverseString(String input) {


			for (int i = input.Length - 1 ; i >= 0; i--) {


				Console.WriteLine(input[i]);
			}

			return "";
		}
    }
}

