using System;
using System.Collections.Generic;


namespace ViagogoDevApp
{
    class CalculateDistance
    {
        public List<Event> events;

        public void CalcEventsDistances(Event[,] WorldSpace, int[] input)
        {
            PrintOutput p = new PrintOutput(); // declare print object to handle printing 
            events = new List<Event>();

            //Remove null indexes of events
            for (int y = 0; y < WorldSpace.GetLength(0); y++)
            {
                for (int x = 0; x < WorldSpace.GetLength(1); x++)
                {
                    if (WorldSpace[y, x] != null)
                        events.Add(WorldSpace[y, x]);
                }
            }
            //calculate the distances from location in events
            foreach (Event e in events)
            {
                int[] eventCoords = e.getCoords();
                e.distance = CalcManhattenDistance(eventCoords[0], input[0], eventCoords[1], input[1]);   
            }
            
            //Sort events based off distance
            events.Sort();
            

            for(int i = 0; i < 3; i++)
            {
                p.printEvent(events[i]);
            }
            Console.ReadKey();

             //printSmallest();
        }
        int CalcManhattenDistance(int x1, int x2, int y1, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
    }
}
