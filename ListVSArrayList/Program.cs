using System.Collections;
using System.Diagnostics;

namespace ListVSArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1000000;

            // Задача 1: Бенчмарк тест
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

            // Задача 2: Count и Capacity
            Console.WriteLine("\n=== ИЗСЛЕДВАНЕ НА COUNT И CAPACITY ===");
            List<int> demoList = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                demoList.Add(i);
                Console.WriteLine($"Element {i,-2} -> Count: {demoList.Count}, Capacity: {demoList.Capacity}");
            }

        }
    }
}
