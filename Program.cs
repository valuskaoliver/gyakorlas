using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

class Homerseklet
{
    static void Main(string[] args)
    { 

        List<int> homer = File.ReadAllLines("homersekletek.txt").Select(int.Parse).ToList();
        
        Console.WriteLine($"A beolvasott napok száma: {homer.Count()}");
    }
}