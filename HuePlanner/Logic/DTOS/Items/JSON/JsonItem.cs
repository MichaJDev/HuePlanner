using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Items.JSON
{
    public class JsonItem
    {
        private string host;
        private string database;
        private string username;
        private string password;

        public JsonItem()
        {
            host = "";
            database = "";
            username = "";
            password = "";
        }

        public JsonItem(string _host, string _database, string _username, string _password)
        {
            host = _host;
            database = _database;
            username = _username;
            password = _password;
        }

        public string GetHost()
        {
            return host;
        }
        public string GetDatabase()
        {
            return database;
        }
        public string GetUserName()
        {
            return username;   
        }

        public string GetPassword()
        {
            return password;
        }
        public void SetHost(string _host)
        {
            host = _host;
        }
        public void SetDatabase(string _database)
        {
            database = _database;
        }
        public void SetUserName(string _username)
        {
            username = _username;
        }

        public void SetPassword(string _password)
        {
            password = _password;
        }
    }
}
