using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Guests.Interface;
using HuePlanner.Logic.DTOS.Locations.Interface;
using HuePlanner.Logic.DTOS.Todos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Parties.Interface
{
    public interface IParty
    {
        public string GetName();

        public ILocation GetLocation();

        public DateTime GetStartTime();

        public DateTime GetEndTime();

        public bool IsStrictStartTime();

        public bool IsStrictEndTime();

        public List<IToDo> GetToDos();

        public List<IGuest> GetInvited();

        public List<IGuest> GetConfirmed();

        public List<IGuest> GetDeclined();

        public double GetBudget();

        public List<IConsumable> GetConsumables();

        public void SetName(string _name);

        public void SetLocation(ILocation _location);

        public void SetStartTime(DateTime _startTime);

        public void SetEndTime(DateTime _endTime);

        public void SetBudget(double _budget);

        public void SetConsumables(List<IConsumable> _consumables);

        public void SetInvited(List<IGuest> _invited);

        public void SetConfirmed(List<IGuest> _confirmed);

        public void SetDeclined(List<IGuest> _declined);

        public void SetToDos(List<IToDo> _todos);

        public void SetStrictStartTime(bool _strictStartTime);

        public void SetStrictEndtime(bool _strictEndTime);
    }
}
