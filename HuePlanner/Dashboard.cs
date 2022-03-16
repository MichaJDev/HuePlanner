using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Users;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;

namespace HuePlanner
{
    public partial class Dashboard : System.Windows.Forms.Form
    {
        IUser user;
        IInterfaceHandler ui;
        IUserDataHandler userData;
        public Dashboard(IUser _user)
        {
            InitializeComponent();
            ui = new InterfaceHandler();
            user = _user;
            userData = new UserDataHandler();
            lblwelcome.Text = $"{user.GetName()} {user.getSurname()}";
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            ui.Close();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            ui.Minimize(this);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void populateContentPanel()
        {

        }
    }
}
