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
        // CREATE operation
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
        

        // READ operation
            // var rooms = from r in context.Rooms select r;
            foreach (var room in context.Rooms)
            {
                Console.WriteLine($"Room {room.Id}," +
                    $" Name: {room.Name}," +
                    $" Has Sunlight? {room.HasSunlight}");
            }

        // UPDATE operation, then read the change in the database
            bedroom.HasSunlight = "false";
            context.SaveChanges();

            foreach (var room in context.Rooms)
            {
                Console.WriteLine($"Room {room.Id}," +
                    $" Name: {room.Name}," +
                    $" Has Sunlight? {room.HasSunlight}");
            }
        }
    }
}