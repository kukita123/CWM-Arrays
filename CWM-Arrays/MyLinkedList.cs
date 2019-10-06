using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWM_Arrays
{
    public class MyLinkedList
    {
        private class Node
        {
            //value:
            public int value;
            //reference to the next element:
            public Node next;

            public Node( int value)
            {
                this.value = value;
            }
        }

        private Node first;        
        private Node last;

        private Boolean isEmpty()
        {
            return first == null;
        }
        //addFirst
        public void addFirst(int item)
        {
            Node node = new Node(item);
            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
        }
        //addLast:
        public void addLast(int item)
        {
            Node node = new Node(item);

            if (isEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }                
        }        
        //deleteFirst
        //deleteLast
        //contains
        //indexOf
    }
}
