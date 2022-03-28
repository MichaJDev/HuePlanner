using HuePlanner.Logic.DTOS.Users;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;
using HuePlanner.Logic.Handlers.Register;
using HuePlanner.Logic.Handlers.Register.Interface;
using HuePlanner.Logic.Security.Encryption;
using HuePlanner.Logic.Security.Encryption.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuePlanner
{
    public partial class Register : System.Windows.Forms.Form
    {
        IInterfaceHandler ui;
        public Register()
        {
            InitializeComponent();
            tbPassword.Text = "";
            tbPassword.PasswordChar = '•';
            lblLogin.ForeColor = Color.AliceBlue;
            ui = new InterfaceHandler();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            ui.Close();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            ui.Minimize(this);
        }

        private void pbSubmit_onClick(object sender, EventArgs e)
        {
            RegisterUser(); 
        }
        private void lblLogin_OnClick(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        private void lblLogin_MouseHover(object sender, EventArgs e)
        {
           lblLogin.ForeColor = Color.Aquamarine;
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.ForeColor = Color.AliceBlue;
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

        private void tbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                RegisterUser();
            }
        }

        private void RegisterUser()
        {
            Form1 form = new Form1();
            IRegisterHandler reg = new RegisterHandler();
            string base64Guid = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            IEncryptionHandler encryption = new EncryptionHandler();
            IUser user = new User(base64Guid.Replace("=", ""), tbName.Text, tbUsername.Text, tbPassword.Text, tbEmail.Text, false);
            string encryptedPw = encryption.Encrypt(user);
            user.SetPassword(encryptedPw);
            reg.Register(user);
            this.Hide();
            form.Show();
        }
    }
}
