using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

class Homerseklet
{
    static void Main(string[] args)
    { 
        string[] lines = File.ReadAllLines("homersekletek.txt");
        List<int> homer = lines.Select(int.Parse).ToList();
        
        Console.WriteLine($"A beolvasott napok száma: {homer.Count()} \n");

        double atlag = homer.Average();

        Console.WriteLine($"Kéthetes átlaghőmérséklet: {atlag}°C \n");

        int max = homer.Max();

        Console.WriteLine($"A legmagasabb hőmérséklet: {max}°C \n");
    }
}