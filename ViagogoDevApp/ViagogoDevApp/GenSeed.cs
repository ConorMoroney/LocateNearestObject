using System;


namespace ViagogoDevApp
{
    class GenSeed
    {
        private Random seed;
        private int curId = 0;
        private Event[,] WorldSpace = new Event[21, 21]; // 2dimesional event array that stores the events

        public void GenerateSeed()
        {
            seed = new Random();
            int noOfEvents = seed.Next(10, 20);//declares the number of events that will be generated between 10-20
            int i = 0;
            while(i < noOfEvents)
            {
                int xCoord = seed.Next(0,20);//generates an x-coordinate in the worldspace
                int yCoord = seed.Next(0,20);//generates an y-coordinate in the worldspace

                if(WorldSpace[xCoord,yCoord] == null)//Checking if the location in worldspace is already populated
                {
                    Event e = new Event(xCoord, yCoord); //if empty put new event in with the coords and iterate i
                    i++;

                    //populate event with id, price, location and number of tickets
                    e.id = ++curId; //iterates through Ids to make sure there are unique
                    e.noOfTickets = seed.Next();//random Number of tickets
                    e.value = Math.Round(seed.NextDouble()*seed.Next(10,30),2); //random ticket price
                    WorldSpace[xCoord, yCoord] = e;
                }
            }
        }
    
        public Event[,] GetGeneratedWorld()//Return the 2d array for future use 
        {
            return WorldSpace;
        }
    }
}
