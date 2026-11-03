using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackExercise
{
    class Program
    {
        public static void ToBin(int x)
        {
            Stack<int> stack = new Stack<int>();
            while (x > 0)
            {                
                stack.Push(x%2);
                x = x / 2;
            }
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
        static void Main(string[] args)
        {
            ToBin(37);
            Console.ReadKey();
            //MyStack stack = new MyStack();

            //for (int i = 3; i < 15; i++)
            //{
            //    stack.Push(i);
            //}

            //int[] array = stack.ToArray();
             
            //Console.WriteLine(String.Join(" ",array));

            //Console.WriteLine(stack.Peek());

            //stack.Pop();

            //Console.WriteLine(stack.Pop());   
            //array = stack.ToArray();

            //Console.WriteLine(String.Join(" ", array));

            //Console.WriteLine(stack.Contains(5));
            //Console.WriteLine(stack.Contains(-2));

            //Console.WriteLine(stack.Count());

            //Console.ReadKey();

            

        }
    }
}
