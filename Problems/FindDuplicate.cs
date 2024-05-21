using System;
using System.Collections.Generic;
using System.IO;

namespace DataStructureV1.Problems
{
class Solution {
    

    //Mc Donals Interview Question
    // Given an array of integers nums containing n + 1 integers 
    // where each integer is in the range [1, n] inclusive:
    // There is only one repeated number in nums; return this repeated number.
    
    // Example cases:
    //  --
    //  Input: 1 3 4 2 2
    //  Output: 2
    //  --
    //  --
    //  Input: 3 1 3 4 2
    //  Output: 3
    //  --
    //  --
    //  Input: 3 3 3 3 3
    //  Output: 3
    //  --
    
    
    // loop through the array 
    // i = 3 
    // j = 1
    

    static int FindDuplicate(int[] nums) {
        // fill this out :)
        
        for(int i = 0; i <= nums.Length; i++){
            
            for(int j = 1; j <= nums.Length - 1; j++){
                
                if (nums[i] == nums[j]){
                    
                    return nums[i];
                }
            }
            
        }
        return -1;
    }


    
    static void Main(String[] args) {
        // setup - don't modify me :)
        string input = Console.ReadLine();
        int[] inputArray = new int[input.Length];
        Console.Write("Input: ");
        for (int i = 0; i < input.Length; i++)
        {
            inputArray[i] = input[i] - '0';
            Console.Write($"{inputArray[i]} ");
        }
        Console.WriteLine();
        
        int duplicate = FindDuplicate(inputArray);
        
        Console.WriteLine($"Answer: {duplicate}");
    }
}     

}