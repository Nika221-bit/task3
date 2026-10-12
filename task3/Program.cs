using System;
using System.Collections.Generic;

class Program
{
    static List<string> names = new List<string> { "David", "Nino", "Nikoloz" };
    static Dictionary<string, int> scores = new Dictionary<string, int> 
    {
        { "David", 85 },
        { "Nino", 92 },
        { "Nikoloz", 78 }
    };
    
    static void Main(string[] args)
    {   
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        bool running = true;
     
        while (running)
        {
            Console.WriteLine("\n=== mtavari meniu ===");
            Console.WriteLine("1. studentis damateba");
            Console.WriteLine("2. studentis modzieba");
            Console.WriteLine("3. qulis shecvla");
            Console.WriteLine("4. studentebis sia");
            Console.WriteLine("5. gamosvla");
            Console.Write("airchie moqmedeba (1-5): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.Write("saxeli: ");
                    string addName = Console.ReadLine();
                    Console.Write("qula: ");
                    int addScore = int.Parse(Console.ReadLine());

                    if (!scores.ContainsKey(addName))
                    {
                        names.Add(addName); 
                        scores.Add(addName, addScore);
                        Console.WriteLine("studenti warmatebit daemata!");
                    }
                    else
                    {
                        Console.WriteLine("studenti ukve arsebobs!");
                    }
                    break;
                
                case "2":
                    Console.Write("modzebne saxelitt: ");
                    string searchName = Console.ReadLine();
            
                    if (scores.ContainsKey(searchName))
                        Console.WriteLine($"qula: {scores[searchName]}");
                    else
                        Console.WriteLine("studenti ver moidzebna");
                    break;
                    
                case "3":
                    Console.Write("visi qulis ganaxleba gsurt: ");
                    string updateName = Console.ReadLine();
            
                    if (scores.ContainsKey(updateName))
                    {
                        Console.Write("axali qula: ");
                        scores[updateName] = int.Parse(Console.ReadLine());
                        Console.WriteLine("qula ganaxlda!");
                    }
                    else
                    {
                        Console.WriteLine("studenti ver moidzebna");
                    }
                    break;
                    
                case "4":
                    Console.WriteLine("\n--- studentebis sia ---");
                    foreach (var name in names)
                    {
                        Console.WriteLine($"{name} - {scores[name]} qula"); 
                    }
                    break;
                    
                case "5":
                    return; 
            }
        }
    }
}