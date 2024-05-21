using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructureV1.Problems
{
    public static class CheckBalance
    {

    // https://www.geeksforgeeks.org/c-program-to-check-for-balanced-brackets-in-an-expression-well-formedness-using-stack-2/?ref=ml_lbp
    // Oracle Interview Question
    // Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid. An input string is valid if:

    // Open brackets must be closed by the same type of brackets.
    // Open brackets must be closed in the correct order.

    // Note that an empty string is also considered valid.
    
    
    // examples:
    // 1. Input: "()"
    //     Output: true
        
    // 2. Input: "(]"
    //     Output: false
    
    // 3. Input: "{[]}"
    //    Output: true
    
    
    // {[)}
    // n = arr[0];  {
    // k = arr[arr.Lenth - 1] = }
    
    // (  )
    // [  ]
    
    // ( [ ) ]
    //       * 
    
    // stack( ->  
    // stack[ ->    
    // stack{ -> {
    
    
    // */
        public static bool Balance(char[] input){
        
            var _stack1 = new Stack<char>();
            var _stack2 = new Stack<char>();
            var _stack3 = new Stack<char>();
            
            for(int i = 0; i < input.Length; i++){
                
                if(i == '('){
                    
                    _stack1.Push(input[i]);
                    
                }else if (i == '{'){
                    
                    _stack2.Push(input[i]);
                    
                } else if(i == '['){
                    
                    _stack3.Push(input[i]);
                }
                
                
                if(i == ')'){
                    
                    _stack1.Pop();

                }
                
            }
            
            /**
                {
            */

            return true;
            
        }
    }
}







