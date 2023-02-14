using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantApp;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new PlantTrackerContext())
        {
            // CREATE: Add Rooms
            var kitchen = new Room
            {
                Name = "Kitchen",
                HasSunlight = "true"
            };
            var bedroom = new Room
            {
                Name = "Bedroom",
                HasSunlight = "true"
            };
            context.Rooms.Add(kitchen);
            context.Rooms.Add(bedroom);
            context.SaveChanges();
        }
    }
}