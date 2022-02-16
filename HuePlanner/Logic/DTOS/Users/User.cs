using HuePlanner.Logic.DTOS.Users.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Users
{
    internal class User : IUser
    {

        private int id;
        private string uuid = "";
        private string name = "";
        private string username = "";
        private string password = "";
        private string email = "";

        public User(int _id, string _uuid, string _name,string _username, string _password, string _email)
        {
            id = _id;
            uuid = _uuid;
            name = _name; 
            username = _username;  
            password = _password;
            email = _email;
        }
        
        public string GetEmail()
        {
            return email;
        }

        public int GetID()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetPassword()
        {
            return password;
        }

        public string GetUserName()
        {
            return username;
        }

        public string GetUUID()
        {
            return uuid;
        }

        public void SetEmail(string _email)
        {
            email = _email;
        }

        public void SetName(string _name)
        {
            name = _name;
        }

        public void SetPassword(string _password)
        {
            password = _password;
        }

        public void SetUserName(string _username)
        {
            username = _username;
        }

        public void SetUUID(string _uuid)
        {
            uuid = _uuid;
        }
    }
}
