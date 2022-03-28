using HuePlanner.Data.Events;
using HuePlanner.Data.Events.Interfaces;
using HuePlanner.Logic.DTOS.Consumables;
using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Enums.Packaging;
using HuePlanner.Logic.DTOS.Parties;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Interface;
using HuePlanner.Logic.Handlers.Interface.Interface;
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
    public partial class CreateEvent : Form
    {
        IInterfaceHandler ui = new InterfaceHandler();
        IEventDataHandler eventData = new EventDataHandler();
        List<IConsumable> consumables = new List<IConsumable>();
        Dashboard form;
        IUser user;
        public CreateEvent(Dashboard _form, IUser _user)
        {
            InitializeComponent();
            form = _form;
            user = _user;
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

        private void pbMin_Click(object sender, EventArgs e)
        {
            ui.Minimize(this);
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbDescription.Clear();
            tbBudget.Clear();
            startDatePick.Refresh();
            endDatePick.Refresh();
            consumables.Clear();
            conName.Clear();
            packageComboBox.SelectedIndex = 0;
            this.Hide();
        }

        private void tbBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IParty p = new Party();
            if (!(String.IsNullOrEmpty(tbName.Text) && String.IsNullOrEmpty(tbDescription.Text) && String.IsNullOrEmpty(tbBudget.Text)))
            {
                p.Name = tbName.Text;
                p.Description = tbDescription.Text;
                p.Budget = Double.Parse(tbBudget.Text);
                p.StartTime = startDatePick.Value;
                p.EndTime = endDatePick.Value;
                p.Owner = user.GetUUID();
                eventData.Create(p);
                foreach (IConsumable consumable in consumables)
                {
                    eventData.UpdateConsumables(consumable, p);
                }

                form.RegenerateOwned();
                tbName.Clear();
                tbDescription.Clear();
                tbBudget.Clear();
                startDatePick.Refresh();
                endDatePick.Refresh();
                consumables.Clear();
                this.Hide();
                
            }
        }

        private void submitCons_Click(object sender, EventArgs e)
        {
            IConsumable con = new Consumable();
            con.Name = conName.Text;
            switch (packageComboBox.Text)
            {
                case "Carton":
                    con.Packaging = PackagingType.CARTON;
                    break;
                case "Alluminium":
                    con.Packaging = PackagingType.ALLUMINIUM;
                    break;
                case "Steel":
                    con.Packaging = PackagingType.STEEL;
                    break;
                case "Plastic":
                    con.Packaging = PackagingType.PLASTIC;
                    break;
            }
            consumables.Add(con);
            lvConsumables.Items.Add(con.Name);
            conName.Clear();

            packageComboBox.SelectedIndex = 0;
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            form.RegenerateOwned();
            tbName.Clear();
            tbDescription.Clear();
            tbBudget.Clear();
            startDatePick.Refresh();
            endDatePick.Refresh();
            consumables.Clear();
            this.Hide();
        }
    }
}
