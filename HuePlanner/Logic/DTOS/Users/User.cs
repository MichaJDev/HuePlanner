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
        private string surname = "";
        private string username = "";
        private string password = "";
        private string email = "";
        private bool isAdmin = false;
        public User(string _uuid, string _name, string _surname, string _username, string _password, string _email, bool _isAdmin)
        {
            uuid = _uuid;
            name = _name;
            surname = _surname;
            username = _username;
            password = _password;
            email = _email;
            isAdmin = _isAdmin;

        }

        public User(string _uuid, string _name, string _username, string _password, string _email, bool _isAdmin)
        {
            uuid = _uuid;
            name = _name;
            username = _username;
            password = _password;
            email = _email;
            isAdmin = _isAdmin;

        }
        public User(string _username, string _password, string _email)
        {
            username = _username;
            password = _password;
            email = _email;
        }
        public User(string _email, string _password)
        {
            email = _email;
            password = _password;
        }
        public User(string _uuid)
        {
            uuid = _uuid;
        }
        public User()
        {
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
        public bool IsAdmin()
        {
            return isAdmin;
        }
        public void SetAdmin(bool admin)
        {
            isAdmin = admin;
        }
        public string getSurname()
        {
            return surname;
        }

        public void setSurname(string _surename)
        {
            surname = _surename;
        }
    }
}
