using System;

namespace ViagogoDevApp
{
    class Event : IComparable<Event>
    {
        private int xCoord; //xcoordinate within 2d array
        private int yCoord; //ycoordinate within 2d array
        private int xWorld; //xcoordinate within (x,y) format
        private int yWorld; //ycoordinate within (x,y) format
        public int distance { get; set; } //Manhatten distance from input
        public int id { get; set; } 
        public double value { get; set; } //Random Price
        public int noOfTickets { get; set; } //random number of tickets

        public Event(int xCoord, int yCoord) // when am event is created it auto populated the world coords of that obj
        {
            this.xCoord = xCoord;
            this.yCoord = yCoord;
            xWorld = (xCoord - 10);
            yWorld = (-1 * yCoord) + 10;
        }

        public int[] getCoords() // returns an array of the world coordinates for an instance of this obj
        {
            return new int[]{xWorld,yWorld};
        }

        public int CompareTo(Event e) //defines how the objects are sorted 
        {
            if (this.distance > e.distance)
                return 1;
            else if (this.distance < e.distance)
                return -1;
            else
                return 0;
        }
    }
}
