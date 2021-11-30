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

            MyArray arr = new MyArray(3);
            arr.insert(10);
            arr.insert(20);
            arr.insert(30);
            arr.print();
            Console.WriteLine();
            arr.insert(40);
            arr.print();
            Console.WriteLine();
            arr.removeAt(1);
            arr.print();
            Console.WriteLine();
            Console.WriteLine(arr.indexOf(30));
            Console.WriteLine(arr.indexOf(300));

            Console.WriteLine(arr.max());
            Console.WriteLine(arr.min());
            Console.WriteLine();

            MyArray other = new MyArray(2);
            other.insert(20);
            other.insert(40);
            other.insertAt(60, 1);
            other.print();
            Console.WriteLine();
            other.reverse();
            other.print();

            Console.WriteLine();
            arr.intersect(other).print();
            #endregion

        

            #region LinkedList
            //MyLinkedList myList = new MyLinkedList();
            //myList.addLast(10);
            //myList.addLast(20);
            //myList.addLast(30);
            //myList.addFirst(44);
            //myList.addLast(7);  //44, 10, 20, 30, 7





            //myList.removeItem(30 );//44,10,20,7
            //Console.WriteLine(myList.indexOf(44));
            //Console.WriteLine(myList.indexOf(10));
            //Console.WriteLine(myList.indexOf(20));
            //Console.WriteLine(myList.indexOf(30));
            //Console.WriteLine(myList.indexOf(7));
            //Console.WriteLine(myList.indexOf(4));
            //myList.removeFirst();
            //Console.WriteLine(myList.contains(7));
            //Console.WriteLine(myList.contains(4));

            //int[] array = myList.toArray();
            //foreach (int item in array) Console.WriteLine(item);

            #endregion

            #region DoublyLinkedList



            #endregion
            Console.ReadKey();
           
        }
    }
}
