// See https://aka.ms/new-console-template for more information
using DataStructureV1;
using DataStructureV1.DataStructures;
using DataStructureV1.Problems;

Console.WriteLine("Hello, World!");

var linebreak = "--------------------";


///var answer = new FizzBuzz(15);


var problem = "Middle of The Linked List";

//var together = problem.Replace(" ", "_");

//Console.WriteLine(together);


//var count  = new Number_of_Steps_to_Reduce_a_Number_to_Zero(14);


Console.WriteLine(linebreak);

//Strings test = new Strings();


//var count  = new Number_of_Steps_to_Reduce_a_Number_to_Zero(14);

Console.WriteLine(linebreak);

problem = "Max Product";

var together = problem.Replace(" ", "_");

Console.WriteLine(together);

int[] arr = { 1, 4, 3, 6, 7, 0 };
int n = arr.Length;
MaxProduct.Solve1(arr, n);
