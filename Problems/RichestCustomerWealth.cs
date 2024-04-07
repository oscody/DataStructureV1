using System;
namespace DataStructureV1.Problems
{
    public class RichestCustomerWealth
    {
        public RichestCustomerWealth()
        {
            Console.WriteLine("1672. Richest Customer Wealth");

            RichestCustomerWealth richestCustomer = new RichestCustomerWealth();


            var accounts = new[,] { { 1, 2, 3 }, { 3, 2, 1 } };

            var maximumWealth = richestCustomer.RichestCustomerWealthV1(accounts);

            Console.WriteLine(maximumWealth);

            Console.WriteLine("1672. Richest Customer Wealth V2");

            var accountsV2 = new int[][] {
                new int[] { 5, 2, 3 },
                new int[] { 3, 2, 1 },
                new int[] { 3, 5, 5 },

            };

            var maximumWealthV2 = RichestCustomerWealthV2(accountsV2);

            Console.WriteLine(maximumWealthV2);

            var maximumWealthV3 = RichestCustomerWealthV2(accountsV2);
            Console.WriteLine(maximumWealthV3);
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

