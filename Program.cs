﻿using System;

namespace UC8_InsertingData40
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Insert(2, 40);
            list.Display();
        }
    }
}
