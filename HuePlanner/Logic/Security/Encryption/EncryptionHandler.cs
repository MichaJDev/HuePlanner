using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Security.Encryption.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Security.Encryption
{
    internal class EncryptionHandler : IEncryptionHandler
    {
        IUserDataHandler userData = new  UserDataHandler();
        public bool Compare(IUser user)
        {
            return BCrypt.Net.BCrypt.Verify(user.GetPassword(), userData.Get(user).GetPassword());
        }

        public string Encrypt(IUser user)
        {
            return BCrypt.Net.BCrypt.HashPassword(user.GetPassword());
        }
    }
}
