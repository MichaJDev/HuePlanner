using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Users;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;
using HuePlanner.Logic.Handlers.Login;
using HuePlanner.Logic.Handlers.Login.Interface;

namespace HuePlanner
{
    public partial class Form : System.Windows.Forms.Form
    {
        IInterfaceHandler ui;
        ILoginHandler login;
        IUserDataHandler userData;
        public Form()
        {
            InitializeComponent();
            tbPassword.Text = "";
            tbPassword.PasswordChar = '•';
            lblRegister.ForeColor = Color.AliceBlue;
            ui = new InterfaceHandler();
            login = new LoginHandler();
            userData = new UserDataHandler();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            ui.Close();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            ui.Minimize(this);
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void lblRegister_MouseHover(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.Aquamarine;
        }

        private void lblRegister_MouseLeave(object sender, EventArgs e)
        {
            lblRegister.ForeColor = Color.AliceBlue;
        }

        private void pbSubmit_Click(object sender, EventArgs e)
        {
            Login();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tbUsername_OnEnter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                Login();
            }
        }
        private void Login()
        {
            IUser user = new User(tbUsername.Text, tbPassword.Text);
            if (login.Login(user))
            {
                IUser nUser = userData.Get(user);
                Dashboard dash = new Dashboard(nUser);
                this.Hide();
                dash.Show();

            }
        }
    }
}