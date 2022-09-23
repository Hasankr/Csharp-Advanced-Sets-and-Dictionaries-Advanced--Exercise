using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                userNames.Add(Console.ReadLine());
            }
            foreach (var userName in userNames)
            {
                Console.WriteLine(userName);
            }
        }
    }
}
