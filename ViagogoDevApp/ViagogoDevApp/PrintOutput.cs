using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViagogoDevApp
{
    class PrintOutput
    {

        public void printWorldSpace(Event[,] WorldSpace)
        {
            for (int y = 0; y < WorldSpace.GetLength(0); y++)
            {
                for (int x = 0; x < WorldSpace.GetLength(1); x++)
                {
                    if (WorldSpace[y, x] != null)
                    {
                        Console.Write(WorldSpace[y, x].id + "\t");
                    }
                    else
                        //Console.Write("*\t");
                        Console.Write((x - (WorldSpace.GetLength(1) / 2)) + "," + ((-1 * y) + (WorldSpace.GetLength(1) / 2)) + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
         
        }
        public void printEvent(Event _event)
        {
            Console.WriteLine("Event " + _event.id.ToString().PadLeft(3,'0') + "- $" + _event.value + ",Distance " + _event.distance + "\n");
        }
    }
}
