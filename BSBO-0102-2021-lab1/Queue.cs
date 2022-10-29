using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBO_0102_2021_lab1
{
    internal class Queue
    {
        public Item? head=null;
        public Item? tail=null;
        public int Pop()
        {
            if (head == null)
                throw new Exception("Queue is empty");

            int result = head.value;

            if (head==tail)
                tail = null;

            head = head.next;
            return result;
        }
        private Item PopItem()
        {
            if (head == null)
                throw new Exception("Queue is empty");

            Item result = head;

            if (head == tail)
                tail = null;

            head = head.next;
            result.next = null;
            return result;
        }
        public void Push(int value)
        {
            Item item = new Item(value, null);

            if (head == null)
                head = item;
            else
                tail.next = item;

            tail = item;
        }
        public void Push(Item item)
        {
            if (head == null)
                head = item;
            else
                tail.next = item;

            tail = item;
        }
        public int Peek()
        {
            if (head == null)
                throw new Exception("Queue is empty");
            return head.value; 
        }
        public int Get(int index)
        {
            if (head == null)
                throw new Exception("Queue is empty");
            
            Item oldHead = head;

            for (int i = 0; i < index; i++)
            {
                Push(PopItem());
            }
            int result = Peek();

            while (head != oldHead)
            {
                Push(PopItem());
            }
            return result;
        }
        public void Set(int index, int newValue)
        {
            if (head == null)
                throw new Exception("Queue is empty");

            Item oldHead = head;

            for (int i = 0; i < index; i++)
            {
                Push(PopItem());
            }
            head.value = newValue;

            while (head != oldHead)
            {
                Push(PopItem());
            }
        }
        public void Print()
        {
            Item queing = head; 
            while (queing != null)
            {
                Console.Write(" " + queing.value);
                queing = queing.next;
            }
        }

    }
}
