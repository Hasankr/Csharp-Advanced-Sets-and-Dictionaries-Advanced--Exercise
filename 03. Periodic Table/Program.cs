using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> periodicElements = new SortedSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] elements = Console.ReadLine().Split();
                periodicElements.UnionWith(elements);
            }
            Console.WriteLine(string.Join(" ", periodicElements));
        }
    }
}
