
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ListVSArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkTest();
            CountAndCapacityDemo();
            ArrayListTypeChecking();
        }

        // Задача 1: Бенчмарк тест
        static void BenchmarkTest()
        {
            int count = 1000000;

            Console.WriteLine("=== БЕНЧМАРК ТЕСТ: ArrayList vs List<int> ===");

            ArrayList arrayList = new ArrayList();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < count; i++)
            {
                arrayList.Add(i); // Boxing
            }

            sw.Stop();
            long timeArrayList = sw.ElapsedMilliseconds;

            Console.WriteLine($"ArrayList ({count} елемента с Boxing): {timeArrayList} ms");

            List<int> genericList = new List<int>();

            sw.Reset();
            sw.Start();

            for (int i = 0; i < count; i++)
            {
                genericList.Add(i); // Без Boxing
            }

            sw.Stop();
            long timeGenericList = sw.ElapsedMilliseconds;

            Console.WriteLine($"List<int> ({count} елемента без Boxing): {timeGenericList} ms");
        }

        // Задача 2: Count и Capacity
        static void CountAndCapacityDemo()
        {
            Console.WriteLine("\n=== ИЗСЛЕДВАНЕ НА COUNT И CAPACITY ===");

            List<int> demoList = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                demoList.Add(i);

                Console.WriteLine($"Element {i,-2} -> Count: {demoList.Count}, Capacity: {demoList.Capacity}");
            }
        }

        // Задача 3: Проверка за типове и обработка на грешки при ArrayList
        static void ArrayListTypeChecking()
        {
            Console.WriteLine("\n=== ПРОВЕРКА ЗА ТИПОВЕ И ОБРАБОТКА НА ГРЕШКИ ПРИ ARRAYLIST ===");

            ArrayList mixedList = new ArrayList();

            mixedList.Add(10);
            mixedList.Add("Hello");
            mixedList.Add(20);
            mixedList.Add("Bautifull");
            mixedList.Add(30);
            mixedList.Add("World");
            mixedList.Add(40);

            foreach (var item in mixedList)
            {
                try
                {
                    int number = (int)item;
                    Console.WriteLine($"Number: {number}");
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine($"Error: Cannot cast '{item}' to int.");
                }
            }
        }
    }
}
