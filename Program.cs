﻿using System;

namespace UC7_SearchLinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Search(30);

            list.Display();
        }
    }
}
