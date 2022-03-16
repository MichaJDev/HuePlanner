using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Handlers.Interface.Interface
{
    public interface IInterfaceHandler
    {
        public void Minimize(System.Windows.Forms.Form form);

        public void Maximize(System.Windows.Forms.Form form);

        public void Close();
    }
}
