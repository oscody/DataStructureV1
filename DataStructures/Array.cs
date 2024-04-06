using System;
namespace DataStructureV1
{
	public class Array
	{
        public string description = "Ordered list of values, typically stored in contigeous blocks of memory";

		public Array()
		{

            //https://www.w3schools.com/cs/cs_arrays.php


            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars1 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars2 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars3 = { "Volvo", "BMW", "Ford", "Mazda" };
        }






	}
}

