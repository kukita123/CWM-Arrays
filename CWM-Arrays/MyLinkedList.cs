﻿using System;
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
            public Node( int value)
            {
                this.value = value;
            }
        }

        private Node first;     //object   
        private Node last;      //object
        private int size;

        private Boolean isEmpty()       
        {
            return first == null;       //if object first is null -> there is no first object -> list is empty
        }
        //addFirst
        public void addFirst(int item)
        {
            Node node = new Node(item); //new object from class Node
            if (isEmpty())
            {
                first = last = node;
            }
            else
            {
                node.next = first;  //reference to previous first object
                first = node;       //the new node becomes the first in the list
            }
            size++;
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
            size++;
        }    
        //indexOf:
        public int indexOf(int item)
        {
            int index = 0;
            var current = first;    //the reference of the current list element (it's second part, that reference to the next element)
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        }
        //contains:
        public Boolean contains(int item)
        {
            return indexOf(item) != -1; //check if item has an index in the list
        }
        //removeFirst:
        public void removeFirst()
        {
            if (isEmpty())
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
        public void removeLast()
        {
            // if:[10 -> 20 -> 30]
            // it's enought to brake the reference between 20 -> 30:
            // 10 -> 20  30
            // and 20 to become the last node
            // we should find the node before the last and break the reference
            // and set it's node.last to null
            // we need the private method to find the previous node - this is private Node getPrevious(Node)
            if (isEmpty())
                throw new InvalidOperationException();
            if (first == last)  //list with one element:
            {
                first = last = null;               
            }
            else
            {
                var previous = getPrevious(last);
                last = previous;
                last.next = null;
            }          
            size--;
        }

        public void removeItem(int item)
        {
            if (isEmpty())
                throw new InvalidOperationException();
            if (first == last)  //list with one element:
            {
                if(first.value != item)
                    throw new InvalidOperationException();
                first = last = null;                    
            }
            else
            {
                if (!contains(item))
                    throw new InvalidOperationException();                
                int index = 0;
                var current = first;
                while (current != null)
                {
                    if (current.value == item)
                        break;
                    current = current.next;
                    index++;
                }
                var previous = getPrevious(current);
                previous.next = current.next;
                current.next = null;
                current = null;
                size--;
            }                
        }

        private Node getPrevious(Node node)
        {
            var current = first;
            while (current != null) //going through the list to find the node before the last
            {
                if (current.next == node) return current;//current.next is the last reference, so current is the node before the last
                current = current.next;
            }
            return null;
        }

        public int listSize()
        {
            return size;
        }
        
        public int[] toArray()
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
