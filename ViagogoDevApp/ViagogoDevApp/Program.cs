using System;
using System.Collections.Generic;

namespace ViagogoDevApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please input coordinates:");
            //generate events randomly 
            GenSeed generatedWorld = new GenSeed();
            generatedWorld.GenerateSeed();
            Event[,] WorldSpace = generatedWorld.GetGeneratedWorld();

            String location = Console.ReadLine();//Read in the Location from user 
            
            //convert the string input into integer array of coordinates
            String[]Coords = location.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] convertedCoords = new int[2];

            //if it can process the input then continue
            for(int i = 0 ; i < Coords.Length ; i++)
            {
                if (Int32.TryParse(Coords[i], out convertedCoords[i]))
                {
                    Console.WriteLine();
                    if (convertedCoords[0] < 20 && convertedCoords[1] < 20)
                    {
                        Console.WriteLine("Closest Events to (" + location + "):\n\n\n");
                        //Preform calculations for the events generated 
                        CalculateDistance c = new CalculateDistance();
                        c.CalcEventsDistances(WorldSpace, convertedCoords);
                    }
                    else
                    {
                        Console.WriteLine("That is outside the coordinatees.\n Coordinates are between -10 & +10 for the x and y axis \n please try again.");
                    }
                }
                else
                    Console.WriteLine("String could not be parsed.");
            }
           Console.ReadKey();
        }
    }
}
