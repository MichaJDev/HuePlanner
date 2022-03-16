using HuePlanner.Logic.DTOS.Users.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Handlers.Login.Interface
{
    public interface ILoginHandler
    {
        public bool Login(IUser user);
    }
}
