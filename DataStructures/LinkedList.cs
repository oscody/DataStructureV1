using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataStructureV1.DataStructures
{

    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    
    public class LinkedList<T>
    {
        private Node<T> head;

        public LinkedList()
        {
            head = null;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
        }

        public void AddLast(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
                return;
            }

            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node<T>(data);
        }

        public bool Remove(T data)
        {
            if (head == null) return false;

            if (head.Data.Equals(data))
            {
                head = head.Next;
                return true;
            }

            Node<T> current = head;
            while (current.Next != null && !current.Next.Data.Equals(data))
            {
                current = current.Next;
            }

            if (current.Next == null) return false;

            current.Next = current.Next.Next;
            return true;
        }

        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public int Count()
        {
            int count = 0;
            Node<T> current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
    }

}