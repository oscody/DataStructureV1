// See https://aka.ms/new-console-template for more information
using DataStructureV1;
using DataStructureV1.Problems;

Console.WriteLine("Hello, World!");

var linebreak = "--------------------";


//Console.WriteLine("Running Sum Of 1D Array V1");

//var testRunningSumOf1DArray = new RunningSumOf1DArray();

//int[] input = new[] { 1, 2, 3, 4 };

//var resultv1 = testRunningSumOf1DArray.RunningSumOf1DArrayV1(input);

//var resultString = string.Join(", ", resultv1);
//Console.WriteLine(resultString);


//Console.WriteLine("Running Sum Of 1D Array V2");

//var resultv2 = testRunningSumOf1DArray.RunningSumOf1DArrayV2(input);

//var resultV2String = string.Join(", ", resultv2);
//Console.WriteLine(resultV2String);


//Console.WriteLine(linebreak);



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

//var maximumWealthV2 = richestCustomer.RichestCustomerWealthV2(accountsV2);

//Console.WriteLine(maximumWealthV2);

var maximumWealthV3 = richestCustomer.RichestCustomerWealthV2(accountsV2);
Console.WriteLine(maximumWealthV3);


Console.WriteLine(linebreak);

