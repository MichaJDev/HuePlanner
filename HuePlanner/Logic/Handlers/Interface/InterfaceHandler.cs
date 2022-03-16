using HuePlanner.Logic.Handlers.Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Handlers.Interface
{
    internal class InterfaceHandler : IInterfaceHandler
    {
        public void Close()
        {
            Application.Exit();
        }

        public void Maximize(System.Windows.Forms.Form form)
        {
           if(form.WindowState == FormWindowState.Maximized)
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
        
    }
}
