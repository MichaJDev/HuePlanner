using HuePlanner.Logic.DTOS.Users.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Security.Encryption.Interface
{
    public interface IEncryptionHandler
    {
        public string Encrypt(IUser user);

        public bool Compare(IUser user);

    }
}
