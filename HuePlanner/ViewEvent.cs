using HuePlanner.Data.Events;
using HuePlanner.Data.Events.Interfaces;
using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Todos;
using HuePlanner.Logic.DTOS.Todos.Interface;
using HuePlanner.Logic.DTOS.Users;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuePlanner
{
    public partial class ViewEvent : Form
    {
        List<IUser> invited = new List<IUser>();
        List<IToDo> todos = new List<IToDo>();
        List<IUser> confirmed = new List<IUser>();
        IUser loggedIn;
        IParty p;
        IEventDataHandler eventData = new EventDataHandler();
        IUserDataHandler userData = new UserDataHandler();
        IInterfaceHandler ui = new InterfaceHandler();
        public ViewEvent(IParty _p, IUser user)
        {
            InitializeComponent();
            loggedIn = user;
            p = _p;
        }

        private void ViewEvent_Load(object sender, EventArgs e)
        {
            lbHeading.Text = p.Name;
            foreach (IConsumable c in eventData.GetConsumables(p))
            {
                if (c != null)
                {
                    lvConsumables.Items.Add($"{c.Name} | {c.Packaging}");
                }
            }
            Debug.Write(p.ID + "\n");
            invited = eventData.GetInvitedList(p);
            foreach (IUser u in eventData.GetInvitedList(p))
            {
                if (u != null)
                {
                    Debug.Write(u.GetName() + "Regel 57\n");
                    lvInvited.Items.Add(u.GetName());
                    //fillInvited(invited);
                }
            }
            confirmed = eventData.GetConfirmed(p);
            foreach (IUser u in eventData.GetConfirmed(p))
            {
                if (u != null)
                {
                    lvConfirmed.Items.Add($"{u.GetName()} {u.getSurname()}");
                    fillConfirmed(confirmed);
                }
            }
            todos = eventData.GetTodos(p);
            foreach (IToDo t in eventData.GetTodos(p))
            {
                if (t != null)
                {
                    lvTodo.Items.Add($"{t.Name} | {t.Description} | {StringifyBoolean(t.IsCompleted)} | ");
                   
                }
            }
            
            cbConfirmed.DataSource = eventData.GetInvited(p).Tables[0];
            cbConfirmed.ValueMember = "name";
            cbConfirmed.DisplayMember = "name";

            cbInvite.DataSource = userData.GetDataSetAll().Tables[0];
            cbInvite.ValueMember = "name";
            cbInvite.DisplayMember = "name";
            //foreach (IUser u in userData.GetAll())
            //{
            //    if (u != null)
            //    {
            //        Debug.Write(u.GetName()+ "Regel 92\n" );
            //        invited.Add(u);
                    
            //}
        }

        public string StringifyBoolean(bool c)
        {
            if (c == true)
                return "Completed";
            return "Not Completed";
        }

        private void pbInvite_Click(object sender, EventArgs e)
        {
            List<IUser> allUsers = userData.GetAll();
            foreach (IUser u in allUsers)
            {
                if (u != null)
                {
                    Debug.Write(cbInvite.SelectedValue + "\n");
                    if (u.GetName() == cbInvite.SelectedValue.ToString())
                    {
                        eventData.UpdateInvited(u, p);
                    }
                }
            }
            invited = eventData.GetInvitedList(p);
            fillInvited(invited);
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pbClose_Click(object sender, EventArgs e)
        {
            lbHeading.Text = "";
            lvConfirmed.Clear();
            lvConsumables.Clear();
            lvInvited.Clear();
            lvTodo.Clear();
            cbConfirmed.Dispose();
            cbInvite.Dispose();
            this.Hide();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            ui.Minimize(this);
        }

        private void close()
        {
            lbHeading.Text = "";
            lvConfirmed.Clear();
            lvConsumables.Clear();
            lvInvited.Clear();
            lvTodo.Clear();
            cbConfirmed.Dispose();
            cbInvite.Dispose();
            this.Hide();
        }

        private void pbTodoSubmit_Click(object sender, EventArgs e)
        {
            IToDo toDo = new ToDo();
            toDo.Name = tbTodo.Text;
            toDo.IsCompleted = false;
            toDo.Description = tbTodo.Text;
            eventData.UpdateTodos(toDo, p);
            fillTodos(eventData.GetTodos(p));
        }
        private void fillTodos(List<IToDo> todos)
        {
            lvTodo.Clear();
            foreach (IToDo t in todos)
            {
                if (t != null)
                    lvTodo.Items.Add($"{t.Name} | {StringifyBoolean(t.IsCompleted)}");
            }
        }
        private void fillInvited(List<IUser> users)
        {
            lvInvited.Clear();
            foreach (IUser u in users)
            {
                if (u != null)
                {

                    lvInvited.Items.Add(u.GetName());
                }
            }
        }
        private void fillConfirmed(List<IUser> confirmed)
        {
            lvConfirmed.Clear();
            foreach (IUser u in confirmed)
            {
                if (u != null)
                {
                    lvConfirmed.Items.Add($"{u.GetName()} {u.getSurname()}");
                }
            }
        }

        private void pbConfirmed_Click(object sender, EventArgs e)
        {
            IUser user = new User();
            foreach (IUser u in userData.GetAll())
            {
                Debug.Write("submitButtomClicked1: " +u.GetName() + "\n");
                Debug.Write("submitButtonSelectedItem: " + cbConfirmed.SelectedValue + "\n");
                if (u.GetName().Contains(cbConfirmed.SelectedValue.ToString()))
                {
                    
                    Debug.Write("submitButtomClicked1: " + u.GetUUID() + "\n");
                    eventData.UpdateConfirmed(u, p);
                    
                }
            }
            List<IUser> newConfirmed = eventData.GetConfirmed(p);
            lvConfirmed.Clear();
            foreach(IUser u in newConfirmed)
            {
                lvConfirmed.Items.Add($"{u.GetName()} {u.getSurname()}");
            }
        }

        private void pbxclose_Click(object sender, EventArgs e)
        {
            close();
        }

        private void pbxdelete_Click(object sender, EventArgs e)
        {
            eventData.Delete(p);
            close();
        }
    }
}
