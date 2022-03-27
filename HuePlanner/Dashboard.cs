using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Users;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;
using System.Diagnostics;
using System.Timers;

namespace HuePlanner
{
    public partial class Dashboard : Form
    {
        IUser user;
        IInterfaceHandler ui;
        public Dashboard(IUser _user)
        {
            InitializeComponent();
            ui = new InterfaceHandler();
            user = _user;
            /*
             * RefreshContent() Erroring on InvalidOperationException something to do with threads 
             */
            // TODO: Revisit
            // Revisit count: 8
            /*
             * tried numerous clearing of controls by contentPanel.Controls.Clear
             * and foreach(Controls c in contentPanel.Controls){ c.dispose(); contentPanel.Remove(c)}
             * 
             * with no luck and only InvalidOperationExceptions
             */
            //RefreshContent();
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
        private void OnLoad(object sender, EventArgs e)
        {
            lblwelcome.Text = $"{user.GetName()} {user.getSurname()}";
            ui.GenerateOwnedEvents(this, user, contentPanel);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            ui.Close();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            ui.Minimize(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CreateEvent eventForm = new CreateEvent(this, user);
            eventForm.Show();
        }
        public void RegenerateOwned()
        {
            foreach (Control c in contentPanel.Controls.OfType<Label>())
            {
                foreach (var item in contentPanel.Controls.OfType<Control>().OrderBy(ee => ee.TabIndex))
                {
                    var l = contentPanel.Controls[item.ToString()];
                    contentPanel.Controls.Remove(l);

                }
                    
                ui.GenerateOwnedEvents(this, user, contentPanel);
            }
        }
        public void RefreshContent()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
            timer.Interval += 5000;
            timer.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            RegenerateOwned();
        }
    }
}

