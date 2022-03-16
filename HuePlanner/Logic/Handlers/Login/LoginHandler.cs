using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Handlers.Login.Interface;
using HuePlanner.Logic.Security.Encryption;
using HuePlanner.Logic.Security.Encryption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Handlers.Login
{
    public class LoginHandler : ILoginHandler
    {
        IEncryptionHandler enc = new EncryptionHandler();
        public bool Login(IUser user)
        {
            IUserDataHandler userData = new UserDataHandler();
            if (userData.Get(user) != null)
            {
                if(enc.Compare(user))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
