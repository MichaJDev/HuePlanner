using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Guests.Interface;
using HuePlanner.Logic.DTOS.Locations;
using HuePlanner.Logic.DTOS.Locations.Interface;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Todos.Interface;

namespace HuePlanner.Logic.DTOS.Parties
{
    public class Party : IParty
    {
        private string name = "";
        private ILocation location = new Location();
        private DateTime startTime;
        private DateTime endTime;
        private bool strictStartTime;
        private bool strictEndTime;
        private List<IToDo> todos = new List<IToDo>();
        private List<IGuest> invited = new List<IGuest>();
        private List<IGuest> confirmed = new List<IGuest>();
        private List<IGuest> declined = new List<IGuest>();
        private double budget;
        private List<IConsumable> consumables = new List<IConsumable>();

        public double GetBudget()
        {
            return budget;
        }

        public List<IGuest> GetConfirmed()
        {
            return confirmed;
        }

        public List<IConsumable> GetConsumables()
        {
            return consumables;
        }

        public List<IGuest> GetDeclined()
        {
            return declined;
        }

        public DateTime GetEndTime()
        {
            return endTime;
        }

        public List<IGuest> GetInvited()
        {
            return invited;
        }

        public ILocation GetLocation()
        {
            return location;
        }

        public string GetName()
        {
            return name;
        }

        public DateTime GetStartTime()
        {
            return startTime;
        }

        public List<IToDo> GetToDos()
        {
             return todos;
        }

        public bool IsStrictEndTime()
        {
            return strictEndTime;
        }

        public bool IsStrictStartTime()
        {
            return strictStartTime;
        }

        public void SetBudget(double _budget)
        {
            budget = _budget;
        }

        public void SetConfirmed(List<IGuest> _confirmed)
        {
            confirmed  = _confirmed;
        }

        public void SetConsumables(List<IConsumable> _consumables)
        {
            consumables = _consumables;
        }

        public void SetDeclined(List<IGuest> _declined)
        {
            declined = _declined;  
        }

        public void SetEndTime(DateTime _endTime)
        {
            endTime = _endTime;
        }

        public void SetInvited(List<IGuest> _invited)
        {
            invited = _invited;
        }

        public void SetLocation(ILocation _location)
        {
            location = _location;
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        public void SetStartTime(DateTime _startTime)
        {
            startTime = _startTime;
        }

        public void SetStrictEndtime(bool _strictEndTime)
        {
            strictEndTime = _strictEndTime;
        }

        public void SetStrictStartTime(bool _strictStartTime)
        {
            strictStartTime = _strictStartTime;
        }

        public void SetToDos(List<IToDo> _todos)
        {
            todos = _todos;
        }
    }
}
