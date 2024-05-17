


namespace DataStructureV1
{

    public class TestQueue<T>{

        private List<T> _queue = new List<T>();

        public TestQueue(){


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

    }


}
