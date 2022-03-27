using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Users;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;

namespace HuePlanner
{
    public partial class EditParty : System.Windows.Forms.Form
    {
        IParty party;
        IInterfaceHandler ui;
        public EditParty(IParty p)
        {
            InitializeComponent();
            ui = new InterfaceHandler();
            party = p;
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
    }
}
