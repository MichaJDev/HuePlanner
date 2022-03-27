using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;

namespace HuePlanner.Logic.Handlers.Interface.Interface
{
    public interface IInterfaceHandler
    {
        public void Minimize(System.Windows.Forms.Form form);
        public void Maximize(System.Windows.Forms.Form form);
        public void Close();
        public void CloseFrame(Form form);
        public void GenerateOwnedEvents(Form form, IUser user, Panel panel);
        public void GenerateInvitedMembers(Form form, IParty p, Panel panel);
        public void GenerateConfirmedMembers(Form form, IParty p, Panel panel);
        public void GenerateDeclinedMembers(Form form, IParty p, Panel panel);
        public void GenerateTodos(Form form, IParty p, Panel panel);
        public void GenerateConsumables(Form form, IParty p, Panel panel);
    }
}
