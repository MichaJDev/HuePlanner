using HuePlanner.Data.Events;
using HuePlanner.Data.Events.Interfaces;
using HuePlanner.Logic.DTOS.Parties;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Handlers.Interface
{

    public class InterfaceHandler : IInterfaceHandler
    {
        private Form? form;
        private IUser? user;
        private IParty? party;
        private Panel? panelMain;
        private string id = "";
        private IEventDataHandler eventData = new EventDataHandler();

        public void Close()
        {
            Application.Exit();
        }

        public void CloseFrame(Form form)
        {
            form.Hide();
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
            FontFamily fontFamily = new FontFamily("Arial");
            Font font = new Font(fontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel);
            Font headingFont = new Font(fontFamily, 18, FontStyle.Bold, GraphicsUnit.Pixel);
            List<IParty> parties = eventData.GetOwned(_user);
            if (parties != null)
            {
                int x = 15;
                int y = 50;
                int width = 500;
                int height = 25;
                Label heading = new Label();
                heading.Text = "Your Events";
                heading.Font = headingFont;
                heading.Location = new Point(15, 15);
                heading.Size = new Size(width, height + 5);
                panel.Controls.Add(heading);

                foreach (IParty p in parties)
                {

                    party = p;
                    form = _form;
                    user = _user;
                    panelMain = panel;

                    Label l = new Label();
                    l.Text = $"{p.Name} | {GetShortString(p.Description)}...";
                    l.Location = new Point(x, y);
                    l.Size = new Size(width, height);
                    l.Font = font;
                    l.Name = p.ID;
                    id = p.Name;
                    l.ForeColor = Color.White;
                    l.Cursor = Cursors.Hand;
                    l.Click += new EventHandler(label_onClick);

                    panel.Controls.Add(l);
                    y += 25;
                }
            }
            else
            {
                int x = 10;
                int y = 10;
                int width = 200;
                int height = 15;
                Label l = new Label();
                l.Text = "You haven't added any events yet";
                panel.Controls.Add(l);
            }
        }

        private void label_onClick(object sender, EventArgs e)
        {
            if (sender is Label)
            {
                party.ID = ((Label)sender).Name;
            }
            Debug.Write(party.ID + "\n");
            IParty p = eventData.Get(party);
            ViewEvent eventView = new ViewEvent(p, user);
            eventView.Show();

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
            if (s != null)
                return s.Substring(0, s.Length - 5);
            return "";
        }
    }
}
