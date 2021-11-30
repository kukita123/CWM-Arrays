using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLists
{
    class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }
    }

    class Person { }

    class Program
    {
        static void Main(string[] args)
        {
            #region MyGenerics
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            int val = intGenericClass.genericMethod(200);
            Console.WriteLine(val);

            Console.WriteLine();

            MyGenericClass<double> doubleGenericClass = new MyGenericClass<double>(3.55);
            double dValue = doubleGenericClass.genericMethod(20);
            Console.WriteLine(dValue);
            #endregion

            #region ArrayList and List Examples

            //// Non-Generics:
            //// ArrayList can only hold Objects and ANYTHING.NET is an Object.
            //ArrayList arrList = new ArrayList();
            //arrList.Add(1);
            //arrList.Add("Hello");
            //arrList.Add(new Person());

            //// Generic example.
            //List<string> list = new List<string>();
            //list.Add("Hello");
            //list.Add("Goodbye");
            //list.Add(new Person()); // This is not allowed, error!
            #endregion

            #region Exercises

            //Exercise1();

            //Exercise2();

            //Exercise3();

            //Exercise4();

            #endregion

            Console.ReadKey();
        }

        public static void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Type your name or hit enter");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} like your post");
            }
            else
                Console.WriteLine();
        }

        public static void Exercise2()
        {
            var numbers = new List<int>();            

            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine($"You've already entered the number {number}");
                    continue;
                }
                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise3()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number (or 'quit' to exit) :");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;
                numbers.Add(int.Parse(input));
            }

            var uniques = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.IndexOf(numbers[i]) != numbers.LastIndexOf(numbers[i]))
                {
                    if (!uniques.Contains(numbers[i]))
                    {
                        uniques.Add(numbers[i]);
                    }
                }
            }
            Console.WriteLine("Uniques numbers:");
            foreach (var number in uniques)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise4()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }

    public class Lists
    {
        // Да се състави програма, която изисква от потребителя да въвежда имена, докато натисне празен Enter. В зависимост от броя 
        // броя въведени имена да извежда следните съобщения:
        //  - Ако никой не харесва постът, не се изписва нищо;
        //  - Ако само един хареса постът, се изписва [Name] likes your post.
        //  - Ако двама харесат постът, се изписва: [Friend 1] and [Friend 2] like your post.
        //  - Ако повече от двама харесат постът, се изписва: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

        public void Exercise1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
        }

        // Да се състави програма, която изисква от потребителя да въведе 5 числа. Ако някое от тях вече е въведено, да се
        // изпише съобщение и да се въведе наново. Петте различни числа да се сортират и изведат на екрана

        public void Exercise2()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.WriteLine(number);
        }


        // Да се състави програма, която изисква от потребителя да въвежда число или "quit" за прекратяване. Числата е възможно да се повтарят.
        // Да се изведат тези от тях, които се срещат повече от един път.

        public void Exercise3()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }


        // Да се състави програма, която изисква от потребителя да въведе списък от числа, разделени със запетая (т. нар. comma - separated 
        // numbers) - например ( 5, 1, 9, 2, 10). Ако списъкът е празен или в него има по-малко от 5 числа, да се изпише: "Invalid List" и
        // да се изисква повторно въвеждане до коректен списък, в противен случай да се изведат трите най-малки числа от списъка.
        
        public void Exercise4()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}



