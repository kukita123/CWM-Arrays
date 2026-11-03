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
            //Console.WriteLine("Min element = {0}", arr.Min());
            //Console.WriteLine("Max element = {0}", arr.Max());
            //Console.WriteLine("Sum: {0}", arr.Sum());
            //Console.WriteLine();
            ////arr.RemoveAt(1);
            ////arr.Print();
            //Console.WriteLine();
            ////arr.RemoveAt(-13);
            ////Console.WriteLine(arr.IndexOf(30));
            ////Console.WriteLine(arr.IndexOf(300));

            //arr.Reverse();
            //Console.WriteLine("Reversed: ");
            //arr.Print();
            ////Console.WriteLine(arr.Max());
            ////Console.WriteLine(arr.Min());
            ////Console.WriteLine();

            //MyListArray other = new MyListArray(2);
            //other.Insert(20);
            //other.Insert(30);
            //other.Insert(40);
            //other.Insert(50);
            //Console.WriteLine("Other: ");
            //other.Print();

            //MyListArray intersect = new MyListArray(2);
            //intersect = arr.Intersect(other);
            //Console.WriteLine("Intersection: ");
            //intersect.Print();
            //Console.WriteLine();

            //MyListArray union = new MyListArray(2);
            //union = arr.Union(other);
            //Console.WriteLine("Union: ");
            //union.Print();
            //Console.WriteLine();

            //MyListArray difference = new MyListArray(2);
            //difference = arr.Difference(other);
            //Console.WriteLine("Difference: ");                
            //difference.Print();



            //other.Reverse();
            //other.Print();

            //Console.WriteLine();
            //arr.Intersect(other).Print();
            //Console.WriteLine();
            #endregion



            #region LinkedList
            Console.WriteLine("Working with Linked List:");
            MyLinkedList myList = new MyLinkedList();
            myList.AddFirst(10);
            myList.AddFirst(20);
            myList.AddLast(44);
            myList.AddFirst(7); // 7  20  10
            myList.AddLast(30); //
            myList.Print(); //7  20  10 44 30
            Console.WriteLine(myList.IndexOf(44));//3


            //myList.RemoveItem(30);//44,10,20,7
            //Console.WriteLine(myList.IndexOf(44));
            //Console.WriteLine(myList.IndexOf(10));
            //Console.WriteLine(myList.IndexOf(20));
            //Console.WriteLine(myList.IndexOf(30));
            //Console.WriteLine(myList.IndexOf(7));
            //Console.WriteLine(myList.IndexOf(4));
            //myList.RemoveFirst();
            //Console.WriteLine(myList.Contains(7));
            //Console.WriteLine(myList.Contains(4));
            //myList.RemoveItem(10);

            //int[] array = myList.ToArray();
            //foreach (int item in array) 
            //    Console.WriteLine(item);

            #endregion

            #region DoublyLinkedList

            //DoublyLinkedList dll = new DoublyLinkedList();
            //dll.AddFirst(10);
            //dll.AddFirst(20);
            //dll.AddLast(30);
            //dll.AddLast(40); //20 10 30 40
            //dll.Print(); //20 10 30 40


            #endregion

            //LinkedList<int> values = new LinkedList<int>();
            //values.AddFirst(10);
            //values.AddFirst(20);
            //values.AddFirst(30);
            //values.AddFirst(40);
            //values.AddAfter(values.First, 100);
            //values.AddBefore(values.Last, 300);
            

            Console.ReadKey();
           
        }
    }
}
