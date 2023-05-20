using System;
using System.Collections.Generic;
using QodenTest_1.Class;

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
