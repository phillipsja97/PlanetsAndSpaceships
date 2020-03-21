using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Saturn");
            planetList.Add("Jupiter");

            List<string> lastTwo = new List<string>() { "Neptune", "Uranus" };
            planetList.AddRange(lastTwo);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Add("Pluto");

            var rockyPlanets = planetList.GetRange(0, 4);
            planetList.Remove("Pluto");
            planetList.ForEach(Console.WriteLine);
            rockyPlanets.ForEach(Console.WriteLine);

            Dictionary<string, string> Shuttles = new Dictionary<string, string>();
            Shuttles.Add("Mars", "Mars-3, Viking-1, Viking-2");
            //Shuttles.Add("Mars", "Viking-1");
            //Shuttles.Add("Mars", "Viking-2");
            Shuttles.Add("Mercury", "Mariner-10, Messenger");
            //Shuttles.Add("Mercury", "Messenger");
            Shuttles.Add("Venus", "Mariner, Vanera");
            //Shuttles.Add("Venus", "Vanera");
            Shuttles.Add("Saturn", "Pioneer 11, Voyager");
            //Shuttles.Add("Saturn", "Voyager");
            Shuttles.Add("Jupiter", "Galileo, Voyager");
            //Shuttles.Add("Jupiter", "Voyager");
            Shuttles.Add("Neptune", "Yolo-22, Haymaker");
            //Shuttles.Add("Neptune", "Haymaker");
            Shuttles.Add("Uranus", "Bidet, TP2020");
            //Shuttles.Add("Uranus", "TP2020");
            Shuttles.Add("Earth", "ALL OF THEM");

            foreach (var planet in planetList)
            {
                Console.WriteLine($"These shuttles, {Shuttles[planet]}, have visited {planet}");
            }
    

            Console.ReadLine();
        }
    }
}
