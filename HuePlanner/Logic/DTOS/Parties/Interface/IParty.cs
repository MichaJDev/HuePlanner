using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Guests.Interface;
using HuePlanner.Logic.DTOS.Locations.Interface;
using HuePlanner.Logic.DTOS.Todos.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Parties.Interface
{
    public interface IParty
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ILocation Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool StrictStartTime { get; set; }
        public bool StrictEndTime { get; set; }
        public List<IToDo> Todos { get; set; }
        public List<IUser> Invited { get; set; }
        public List<IUser> Confirmed { get; set; }
        public List<IUser> Declined { get; set; }
        public double Budget { get; set; }
        public List<IConsumable> Consumables { get; set; }
        public string Owner { get; set; }
    }
}
