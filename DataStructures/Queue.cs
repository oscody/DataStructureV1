


namespace DataStructureV1
{

    public class Queue<T>{

        // Queue is a FIFO data structure

        private List<T> _queue = new List<T>();

        public Queue(){


        }
        public void Enqueue(T item){


            _queue.Add(item);
        }
        public T Dequeue(){


            if(_queue.Count == 0){

                throw new InvalidOperationException("");
            }
        
            var item = _queue[0];
            _queue.Remove(item);
            return item;
        
        
        }

        public T Peek(){
            if(_queue.Count == 0){
                throw new InvalidOperationException("");
            }

            return _queue[0];
        }

    }


}
