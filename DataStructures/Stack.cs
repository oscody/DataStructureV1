using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructureV1.DataStructures
{
    public class Stack<T>
    {

        // Stack is a LIFO data structure
        private List<T> _stack;

        public Stack(){
            _stack = new List<T>();
        }

        public void Pop(){
                
                if(_stack.Count == 0){
                    throw new InvalidOperationException("Stack is empty");
                }
    
                _stack.RemoveAt(_stack.Count - 1);

        }


        public void Push(T data){

            _stack.Add(data);
        }


        public T Peek(){

            if(_stack.Count == 0){
                throw new InvalidOperationException("Stack is empty");
            }

            return _stack[_stack.Count - 1];
        }

        public int Count(){
            return _stack.Count;
        }
    }
}