using HuePlanner.Data.Events;
using HuePlanner.Data.Events.Interfaces;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Handlers.Interface
{
   
    public class InterfaceHandler : IInterfaceHandler
    {
        Form? form;
        IUser? user;
        IParty? party;
        Panel? panelMain;

        private IEventDataHandler eventData = new EventDataHandler();

        public void Close()
        {
            Application.Exit();
        }

        public void Maximize(System.Windows.Forms.Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
            }
        }

        public void Minimize(System.Windows.Forms.Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public IUser? GetUser()
        {
            return user;
        }

        public void GenerateOwnedEvents(Form _form, IUser _user, Panel panel)
        {
            List<IParty> parties = eventData.GetOwned(_user);
            foreach (IParty p in parties)
            {
                party = p;
                form = _form;
                user = _user;
                panelMain = panel;
                int x = 10;
                int y = 10;
                int width = 200;
                int height = 15;
                Label l = new Label();
                l.Text = $"{p.Name} | {GetShortString(p.Description)} | {p.Invited.Count()} | { p.Confirmed.Count()}";
                l.Location = new Point(x, y);
                l.Size = new Size(width, height);
                l.Font = new Font(FontFamily.GenericSerif, 15);
                PictureBox editBox = new PictureBox();
                editBox.Location = new Point(x, y + width + 10);
                editBox.Size = new Size(32, 32);
                editBox.SizeMode = PictureBoxSizeMode.StretchImage;
                editBox.BackgroundImage = Properties.Resources.edit;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
                editBox.Click += new EventHandler(PBEdit_OnClick);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
                editBox.Cursor = Cursors.Hand;
                PictureBox deleteBox = new PictureBox();
                deleteBox.Location = new Point(x, y + width + 52);
                deleteBox.Size = new Size(32, 32);
                deleteBox.SizeMode = PictureBoxSizeMode.StretchImage;
                deleteBox.BackgroundImage = Properties.Resources.delete;
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
                deleteBox.Click += new EventHandler(PBDelete_OnClick);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
                deleteBox.Cursor = Cursors.Hand;

                panel.Controls.Add(l);
                panel.Controls.Add(editBox);
                panel.Controls.Add(deleteBox);
                y += 25;
            }
        }
        public void GenerateInvitedMembers(Form form, IParty p, Panel panel)
        {

        }
        public void GenerateConfirmedMembers(Form form, IParty p, Panel panel)
        {

        }
        public void GenerateDeclinedMembers(Form form, IParty p, Panel panel)
        {

        }
        public void GenerateTodos(Form form, IParty p, Panel panel)
        {

        }
        public void GenerateConsumables(Form form, IParty p, Panel panel)
        {

        }

        private string GetShortString(string s)
        {
            return s.Substring(0, 15);
        }
        private void PBDelete_OnClick(object sender, EventArgs e)
        {
            eventData.Delete(party);
            GenerateOwnedEvents(form, user, panelMain);
        }
        private void PBEdit_OnClick(object sender, EventArgs e)
        {
        }
    }
}
