using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Guests.Interface;
using HuePlanner.Logic.DTOS.Locations;
using HuePlanner.Logic.DTOS.Locations.Interface;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Todos.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;

namespace HuePlanner.Logic.DTOS.Parties
{
    public class Party : IParty
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



