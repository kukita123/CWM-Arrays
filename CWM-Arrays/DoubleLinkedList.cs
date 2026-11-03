using System;

namespace CWM_Arrays
{
    public class DoublyLinkedList
    {
        public class Node
        {
            public int item;
            public Node next;
            public Node prev;

            public Node(int value)
            {
                item = value;
            }
        }

        private Node head;
        private Node tail;
        public int Size { get; set; }

        public DoublyLinkedList()
        {
            this.Size = 0;
            this.head = null;
            this.tail = null;
        }
        private bool IsEmpty()
        {
            return head == null;
        }
        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            if (IsEmpty())
            {
                newNode.prev = null;
                head = newNode;
                tail = newNode;
                return;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
                newNode.prev = null;
            }

        }
        private Node GetPrevious(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.next.item == value)
                {
                    return current;
                }
                current = current.next;
            }
            return null;
        }

        //public void InsertAfter(int value)
        //{
        //    if(GetPrevious(value) == null)
        //    {
        //        throw new Exception("Previous can't be null");                
        //    }

        //    Node newNode = new Node(value);

        //    newNode.next = previous.next;

        //    previous.next = newNode;

        //    newNode.prev = previous;

        //    if (newNode.next != null)
        //        newNode.next.prev = newNode;
 
        //}

        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (IsEmpty())
            {
                newNode.prev = null;
                head = newNode;
                tail = newNode;
                return;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            
        }
        public void Print()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.item + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
