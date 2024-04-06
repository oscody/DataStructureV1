using System;
namespace DataStructureV1.Problems
{
    public class RichestCustomerWealth
    {
        public RichestCustomerWealth()
        {
        }



        public int RichestCustomerWealthV1(int[,] accounts)
        {


            int[] maxWealth = new int[2];

            int richestCustomer = 0;


            for (int i = 0; i < accounts.GetLength(0); i++)
            {


                int highestTotal = 0;

                for (int j = 0; j < accounts.GetLength(1); j++)
                {


                    //Console.WriteLine(accounts[i, j]);
                    maxWealth[i] += accounts[i, j];

                    highestTotal += accounts[i, j];

                }

                Console.WriteLine(highestTotal);

                if (highestTotal >= richestCustomer)
                {

                    richestCustomer = highestTotal;

                }
            }

            var result = string.Join(", ", maxWealth);
            Console.WriteLine(result);

            return richestCustomer;
        }


        public int RichestCustomerWealthV2(int[][] accounts)
        {
            int richestCustomer = 0;


            for (int i = 0; i < accounts.Length; i++)
            {


                int highestTotal = 0;

                for (int j = 0; j < accounts[i].Length; j++)
                {

                    highestTotal += accounts[i][j];

                }

                if (highestTotal >= richestCustomer)
                {

                    richestCustomer = highestTotal;

                }
            }


            return richestCustomer;
        }



        public int RichestCustomerWealthV3(int[][] accounts)
        {
            int richestCustomer = 0;


            foreach (int[] customer in accounts)
            {


                int highestTotal = 0;

                foreach (int bank in customer)
                {

                    highestTotal += bank;

                }

                if (highestTotal >= richestCustomer)
                {

                    richestCustomer = highestTotal;

                }
            }


            return richestCustomer;
        }
    }
}

