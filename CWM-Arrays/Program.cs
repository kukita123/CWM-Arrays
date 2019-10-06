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
            MyArray arr = new MyArray(3);
            arr.insert(10);
            arr.insert(20);
            arr.insert(30);
            arr.print();
            Console.WriteLine();
            arr.insert(30);
            arr.print();
            Console.WriteLine();
            arr.removeAt(1);
            arr.print();
            Console.WriteLine();
            Console.WriteLine(arr.indexOf(30));
            Console.WriteLine(arr.indexOf(300));
            

            //ArrayList arrList = new ArrayList();

            //MyLinkedList last = new MyLinkedList();
            //last.addLast(10);
            //last.addLast(20);
            //last.addLast(30);

           
        }
    }
}
