using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothesByColor = new Dictionary<string, Dictionary<string, int>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[0];
                if (!clothesByColor.ContainsKey(color))
                {
                    clothesByColor[color] = new Dictionary<string, int>();
                }
                for (int j = 1; j < tokens.Length; j++)
                {
                    if (!clothesByColor[color].ContainsKey(tokens[j]))
                    {
                        clothesByColor[color].Add(tokens[j], 0);

                    }
                    clothesByColor[color][tokens[j]]++;
                }
            }
            string[] findParams = Console.ReadLine().Split();
            foreach (var colorCloth in clothesByColor)
            {
                Console.WriteLine($"{colorCloth.Key} clothes:");
                foreach (var cloth in colorCloth.Value)
                {
                    string printItem = $"* {cloth.Key} - {cloth.Value}";
                    if (colorCloth.Key == findParams[0] && cloth.Key == findParams[1])
                    {
                        printItem += " (found!)";
                    }
                    Console.WriteLine(printItem);
                }
            }
        }
    }
}
