using System;
using System.Collections.Generic;
using System.IO;

namespace DataStructureV1.Problems
{
    public static class FindDuplicate {
        

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

        public static void RunCode(){

            int [] inputArray = {1, 3, 4, 2, 2};
            int duplicate = Solution1(inputArray);
            
            Console.WriteLine($"Answer: {duplicate}");
    
        }
        

        private static int Solution1(int[] nums) {
            
            for(int i = 0; i < nums.Length - 1 ; i++){
                
                for(int j = i + 1; j < nums.Length; j++){
                    
                    if (nums[i] == nums[j]){
                        
                        return nums[i];
                    }
                }
                
            }
            return -1;
        }
    }     

}