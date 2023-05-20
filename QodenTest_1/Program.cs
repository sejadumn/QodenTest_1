using System;
using System.Collections.Generic;

public class ListNode
{
    public int value;
    public ListNode next;

    public ListNode(int value)
    {
        this.value = value;
        next = null;
    }

    public void Insert(int newValue)
    {
        ListNode newNode = new ListNode(newValue);
        newNode.next = next;
        next = newNode;
    }
}

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

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите N:");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите элементы для добавления в хэш-таблицу (через пробел):");
        string input = Console.ReadLine();

        string[] elements = input.Split(' ');

        HashTable hashTable = new HashTable(N);

        foreach (string element in elements)
        {
            if (int.TryParse(element, out int value))
            {
                hashTable.Insert(value);
            }
            else
            {
                Console.WriteLine("Некорректный элемент: " + element);
            }
        }

        Console.WriteLine("Содержимое хэш-таблицы:");
        hashTable.PrintTable();
    }
}
