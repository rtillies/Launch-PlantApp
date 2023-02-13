using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantApp
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HasSunlight { get; set; }
        public List<Plant> Plants { get; set; }
    }
}
