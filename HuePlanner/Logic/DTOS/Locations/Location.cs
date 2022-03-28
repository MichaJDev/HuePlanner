using HuePlanner.Logic.DTOS.Locations.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Locations
{
    public class Location : ILocation
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public char Addition { get; set; }
        public string PostalCode { get; set; }
        public string TownShip { get; set; }
    }
}
