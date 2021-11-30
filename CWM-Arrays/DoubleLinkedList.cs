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

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);

            newNode.next = head;
            newNode.prev = null;

            if (head != null)
                head.prev = newNode;

            head = newNode;
        }

        public void InsertAfter(Node previous, int value)
        {
            if(previous == null)
            {
                throw new Exception("Previous can't be null");                
            }

            Node newNode = new Node(value);

            newNode.next = previous.next;

            previous.next = newNode;

            newNode.prev = previous;

            if (newNode.next != null)
                newNode.next.prev = newNode;
 
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            Node current = head;

            newNode.next = null;

            if(current == null)  //empty list
            {
                newNode.prev = null;
                head = newNode;
                return;
            }

            while (current != null)
                current = current.next;  //the tail - last element

            current.next = newNode;
            newNode.next = current;
        }
    }
}
