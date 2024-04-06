// See https://aka.ms/new-console-template for more information
using DataStructureV1;

Console.WriteLine("Hello, World!");


Console.WriteLine("Running Sum Of 1D Array V1");

var testRunningSumOf1DArray = new RunningSumOf1DArray();

int[] input = new[] { 1, 2, 3, 4 };

var resultv1 = testRunningSumOf1DArray.RunningSumOf1DArrayV1(input);

var resultString = string.Join(", ", resultv1);
Console.WriteLine(resultString);


Console.WriteLine("Running Sum Of 1D Array V2");

var resultv2 = testRunningSumOf1DArray.RunningSumOf1DArrayV2(input);

var resultV2String = string.Join(", ", resultv2);
Console.WriteLine(resultV2String);