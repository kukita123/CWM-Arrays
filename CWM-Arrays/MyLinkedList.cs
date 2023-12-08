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

            //Node constructor:
            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node first;     //object   
        private Node last;      //object
        private int size;

        private Boolean IsEmpty()       
        {
            return first == null;       //if object first is null -> there is no first object -> list is empty
        }

        //addFirst
        public void AddFirst(int item)
        {
            Node node = new Node(item); //new object from class Node
            if (IsEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;  //reference to previous first object
                first = node;       //the new node becomes the first in the list
            }
            size++; //!!!
        }

        //addLast:
        public void AddLast(int item)
        {
            Node node = new Node(item);

            if (IsEmpty())
            {
                first = node;
                last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            size++; //!!!
        }   
        
        //indexOf:
        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;    //the reference of the current list element (it's second part,
                                    //that refer to the next element)
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        //contains:
        public Boolean Contains(int item)
        {
            return IndexOf(item) != -1; //check if item has an index in the list
        }

        //removeFirst:
        public void RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException();
            if (first == last)  //list with one element:
            {
                first = last = null;               
            }
            else
            {
            // if:[10 -> 20 -> 30]
            // it's enought to brake the reference between 10 -> 20:
            // 10  20 -> 30
            // and 20 to become the first node
            var second = first.next; //remembers the reference from first to second (prevent from loosing it) 
            first.next = null; //deletes the reference from first to second 
            first = second; //the new first node gets the reference from the variable second;
            }
            size--;
        }  
        
        //removeLast:
        public void RemoveLast()
        {
            // if:[10 -> 20 -> 30]
            // it's enought to brake the reference between 20 -> 30:
            // 10 -> 20  30
            // and 20 to become the last node
            // we should find the node before the last and break the reference
            // and set it's node.last to null
            // we need the private method to find the previous node - this is private Node getPrevious(Node)
            if (IsEmpty())
                throw new InvalidOperationException();
            if (first == last)  //list with one element:
            {
                first = last = null;               
            }
            else
            {
                var previous = GetPrevious(last);
                last = previous;
                last.next = null;
            }          
            size--;
        }
        public void RemoveItem(int item)
        {
            if (!Contains(item))
                throw new InvalidOperationException();
            //if(first == last && first.value == item)
            //{
            //    first = last = null;
            //}
            if (first.value == item)
            {
                RemoveFirst();
                return;
            }
            else
            {
                var current = first;    
                while (current != null)
                {
                    if (current.value == item)
                    {
                        var previous = GetPrevious(current);
                        previous.next = current.next;
                        current.next = null;
                        current = null;
                        break;
                    }                    
                    current = current.next;                     
                }
            }
            size--;
        }

        private Node GetPrevious(Node node)
        {
            var current = first;
            while (current != null) //going through the list to find the node before the last
            {
                if (current.next == node) 
                    return current;//current.next is the last reference,
                                   //so current is the node before the last
                current = current.next;
            }
            return null;
        }
        public int ListSize()
        {
            return size;  //
        }
               
        public int[] ToArray()
        {
            int[] array = new int[size];
            Node current = first;
            int index = 0;
            while (current != null)
            {
                array[index] = current.value;
                index++;
                current = current.next;
            }

            return array;
        }
    }
}
