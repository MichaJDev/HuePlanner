using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Register.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Handlers.Register
{
    public class RegisterHandler : IRegisterHandler
    {
        IUserDataHandler userData = new UserDataHandler();
        public void Register(IUser user)
        {
            userData.Create(user);
        }
    }
}
