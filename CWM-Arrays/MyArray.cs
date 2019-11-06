using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWM_Arrays
{
    public class MyArray
    {
        private int[] items;
        private int count;

        //constructor:
        public MyArray(int length)
        {
            items = new int[length];

            Console.WriteLine("count={0}", count);
        }

        public void insert(int item)
        {
            //if the array is full, resize it
            if (items.Length == count)
            {
                Array.Resize(ref items, count*2);
            }
            //add the item at the end
            items[count++] = item;            
        }
        
        public void removeAt(int index)
        {
            //validate the index
            if (index < 0 || index >= count)
            {
                throw new Exception();
            }
            //shift the items to the left to fill the hole
            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }

        public int indexOf(int item)
        {
            //if we find it, return index
            //otherwise return -1
            for (int i = 0; i < count; i++)
            {
                if (items[i]==item)
                {
                    return i;
                }
            }
            return -1;
        }

        //exercises:
        /*
        1- Extend the Array class and add a new method to return the largest and the smallest  number. 
        What is the runtime complexity of this method?  Solution: Array.max(): 
        */
        public int max()
        {
            int max = items[0];
            foreach (var item in items)
            {
                if (item>max)
                {
                    max = item;
                }
            }
            return max;
        }
        public int min()
        {
            int min = items[0];
            foreach (var item in items)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        /*
        2- Extend the Array class and add a method to return the common items in this 
        array and another array.  Solution: Array.intersect(): 
        */
        public MyArray intersect(MyArray other)
        {
            var intersection = new MyArray(count); //the array to generate and return, max length=count
            foreach (var item in items)
            {
                if (other.indexOf(item) >= 0) //checks if item has an index in other
                {
                    intersection.insert(item);
                }
            }
            return intersection;
        }
        /*
        3- Extend the Array class and add a method to reverse the array. For example, 
        if the array includes [1, 2, 3, 4], after reversing and printing it, 
        we should see [4, 3, 2, 1].  Solution: Array.reverse() 
        */
        public void reverse()
        {
            int[] newRevItems = new int[count];
            for (int i = 0; i < items.Length; i++)
            {
                newRevItems[i] = items[items.Length - 1 - i];
            }
            items = newRevItems;
        }
        /*
        4-  Extend the Array class and add a new method to insert an item at a given index: 
        public void insertAt(int item, int index)Solution: Array.insertAt() 

         // Note that I've extracted the logic for resizing the array into this private
        // method so we can reuse in insert() and insertAt() methods.
        // 
        // This also made our code cleaner and more readable.
        //        
        */
        public void ResizeIfRequired()
        {
            if (items.Length==count)
            {
                int[] newItems = new int[2 * count];
                for (int i = 0; i < count; i++)
                {
                    newItems[i] = items[i];
                }
                items = newItems;
            }
        }
        public void insertAt(int item, int index)
        {
            ResizeIfRequired();
            //pushes all elements after index one position back:
            for (int i = count-1; i >= index; i--)
            {
                items[i + 1] = items[i];
            }
            items[index] = item;
            count++;
        }

        public void print()
        {
            for(int i=0;i<count;i++)
                Console.WriteLine(items[i]);
        }
    }
}
