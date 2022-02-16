using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Users.Interface
{
    public interface IUser
    {

        public int GetID();
        public string GetUUID();
        public string GetName();
        public string GetUserName();
        public string GetPassword();
        public string GetEmail();
        public void SetUUID(string _uuid);
        public void SetName(string _name);
        public void SetUserName(string _username);
        public void SetPassword(string _password);
        public void SetEmail(string _email);

    }
}
