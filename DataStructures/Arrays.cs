using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructureV1
{
	public class Arrays
	{

        //reference type  
        public string description = "Ordered list of values, typically stored in contigeous blocks of memory";

		public Arrays()
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



        public void MultiArray()
        {
            int[,] num = new int[2, 3] { { 2, 3, 6 }, { 3, 7, 9 } };


            int[,] num2 = { { 2, 3, 6 }, { 3, 7, 9 } };


            for (int j = 0; j < num2.GetLength(0); j++)
            {


                for (int i = 0; i < num2.GetLength(1); i++)
                {

                }
            }

        
        }



        public void JaggedArray()
        {
            int[][] num = new int[2][];
            num[0] = new int[1];
            num[1] = new int[2];


            for (int j = 0; j < num.Length; j++)
            {


                for (int i = 0; i < num[i].Length; i++)
                {

                }
            }


        }
    }
}

