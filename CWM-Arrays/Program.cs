using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWM_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DynamicArray-List

            //MyListArray arr = new MyListArray(3);
            //arr.Insert(10);
            //arr.Insert(20);
            //arr.Insert(30);
            //arr.Print();
            //Console.WriteLine();
            //arr.Insert(40);
            //arr.Print();
            //Console.WriteLine();
            //arr.RemoveAt(1);
            //arr.Print();
            //Console.WriteLine();
            //Console.WriteLine(arr.IndexOf(30));
            //Console.WriteLine(arr.IndexOf(300));

            //Console.WriteLine(arr.Max());
            //Console.WriteLine(arr.Min());
            //Console.WriteLine();

            //MyListArray other = new MyListArray(2);
            //other.Insert(20);
            //other.Insert(40);
            //other.InsertAt(60, 1);
            //other.Print();
            //Console.WriteLine();
            //other.Reverse();
            //other.Print();

            //Console.WriteLine();
            //arr.Intersect(other).Print();
            //Console.WriteLine();
            #endregion



            #region LinkedList
            Console.WriteLine(  "Working with Linked List:");
            MyLinkedList myList = new MyLinkedList();
            myList.AddLast(10);
            myList.AddLast(20);
            myList.AddLast(30);
            myList.AddFirst(44);
            myList.AddLast(7);  //44, 10, 20, 30, 7

            myList.RemoveItem(30);//44,10,20,7
            Console.WriteLine(myList.IndexOf(44));
            Console.WriteLine(myList.IndexOf(10));
            Console.WriteLine(myList.IndexOf(20));
            Console.WriteLine(myList.IndexOf(30));
            Console.WriteLine(myList.IndexOf(7));
            Console.WriteLine(myList.IndexOf(4));
            myList.RemoveFirst();
            Console.WriteLine(myList.Contains(7));
            Console.WriteLine(myList.Contains(4));
            myList.RemoveItem(10);

            int[] array = myList.ToArray();
            foreach (int item in array) 
                Console.WriteLine(item);

            #endregion

            #region DoublyLinkedList



            #endregion
            Console.ReadKey();
           
        }
    }
}
