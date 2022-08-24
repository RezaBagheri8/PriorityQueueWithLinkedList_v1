using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueWithLinkedList
{
    public class PriorityQueue
    {
        public Node head;

        public void Enqueue(int value, int priority)
        {
            if (head == null)
            {
                Node newItem = new Node();
                newItem.value = value;
                newItem.Priority = priority;
                head = newItem;
            }
            else
            {
                Node newItem = new Node();
                newItem.value = value;
                newItem.Priority = priority;


                Node node = head;
                while (node.next != null)
                {
                    node = node.next;
                }

                newItem.prev = node;
                node.next = newItem;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                Node node = head.next;
                int maxPriority = head.Priority;
                Node maxNode = head;
                while (node != null)
                {
                    if (maxPriority < node.Priority)
                    {
                        maxPriority = node.Priority;
                        maxNode = node;
                    }
                    node = node.next;
                }

                if (maxNode.prev == null)
                {
                    Console.WriteLine("value : " + maxNode.value + " || Priority : " + maxNode.Priority);
                    head = head.next;
                    maxNode = null;
                }
                else if(maxNode.next == null)
                {
                    Console.WriteLine("value : " + maxNode.value + " || Priority : " + maxNode.Priority);
                    maxNode.prev.next = null;
                    maxNode = null;
                }
                else
                {
                    Console.WriteLine("value : " + maxNode.value + " || Priority : " + maxNode.Priority);
                    maxNode.prev.next = maxNode.next;
                    maxNode = null;
                }
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                Node node = head;
                while(node != null)
                {
                    Console.WriteLine("value : " + node.value + " || Priority : " + node.Priority);

                    node = node.next;
                }
            }
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
