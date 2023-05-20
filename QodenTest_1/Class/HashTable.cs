using System;
using System.Collections.Generic;

namespace QodenTest_1.Class
{
    public class HashTable
    {
        public List<ListNode>[] values;

        public HashTable(int size)
        {
            values = new List<ListNode>[size];
            for (int i = 0; i < size; i++)
            {
                values[i] = new List<ListNode>();
            }
        }

        private int HashFunction(int x, int size)
        {
            return x % size;
        }

        public void Insert(int newValue)
        {
            int index = HashFunction(newValue, values.Length);
            if (values[index].Count == 0)
            {
                values[index].Add(new ListNode(newValue));
            }
            else
            {
                values[index][0].Insert(newValue);
            }
        }

        public void PrintTable()
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"m{i}: ");
                foreach (ListNode node in values[i])
                {
                    ListNode currNode = node;
                    while (currNode != null)
                    {
                        Console.Write(currNode.value + " ");
                        currNode = currNode.next;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
