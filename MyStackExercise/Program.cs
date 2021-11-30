using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            for (int i = 3; i < 15; i++)
            {
                stack.Push(i);
            }

            int[] array = stack.ToArray();
             
            Console.WriteLine(String.Join(" ",array));

            Console.WriteLine(stack.Peek());

            stack.Pop();

            Console.WriteLine(stack.Pop());   
            array = stack.ToArray();

            Console.WriteLine(String.Join(" ", array));

            Console.WriteLine(stack.Contains(5));
            Console.WriteLine(stack.Contains(-2));

            Console.WriteLine(stack.Count());

            Console.ReadKey();
        }
    }
}
