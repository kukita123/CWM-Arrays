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

        public MyArray(int length)
        {
            items = new int[length];
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

        public void print()
        {
            for(int i=0;i<count;i++)
                Console.WriteLine(items[i]);
        }
    }
}
