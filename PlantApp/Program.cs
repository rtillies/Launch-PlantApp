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

            /*            // CREATE: Add Plants
                        var pothos = new Plant
                        {
                            Type = "Pothos",
                            PurchaseDate = new DateTime(2023, 2, 14, 12, 0, 0),
                            Room = kitchen
                        };
                        context.Plants.Add(pothos);
                        context.SaveChanges();
            */
            
        }

        using (var context = new PlantTrackerContext())
        {
            var rooms = from r in context.Rooms select r;
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room {room.Id}," +
                    $" Name: {room.Name}," +
                    $" Has Sunlight? {room.HasSunlight}");
            }
        }
    }
}