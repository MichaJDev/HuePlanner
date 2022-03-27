using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Enums.EditTypes.Parties;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Todos.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;

namespace HuePlanner.Data.Events.Interfaces
{
    public interface IEventDataHandler
    {
        public IParty Get(IParty p);
        public void Create(IParty p);
        public void Delete(IParty p);
        public void Update(PartyEditType type, IParty p);
        public void UpdateTodos(IParty p);
        public void UpdateConfirmed(IParty p);
        public void UpdateDeclined(IParty p);
        public void UpdateInvited(IParty p);
        public void UpdateConsumables(IParty p);
        public List<IUser> GetConfirmed(IParty p);
        public List<IUser> GetDeclined(IParty p);
        public List<IUser> GetInvited(IParty p);
        public List<IToDo> GetTodos(IParty p);
        public List<IParty> GetOwned(IUser user);
        public List<IConsumable> GetConsumables(IParty p);

    }
}
