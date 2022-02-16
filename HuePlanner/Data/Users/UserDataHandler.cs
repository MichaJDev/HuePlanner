using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Items.JSON;
using HuePlanner.Logic.DTOS.Users.Interface;
using HuePlanner.Logic.Readers.JSON;
using HuePlanner.Logic.Readers.JSON.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Data.Users
{
    internal class UserDataHandler : IUserDataHandler
    {
        public void Create(IUser user)
        {
            IJsonReader reader = new JsonReader();
            JsonItem jItem = reader.DeserializeFile(@".\JsonFiles\host.json");
            string conString = $"Server={jItem.GetHost()}";
            using(SqlConnection con = new SqlConnection())
            {
                
                using (SqlCommand cmd = con.CreateCommand())
                {
                    
                }
            }
        }

        public void Delete(IUser user)
        {
            throw new NotImplementedException();
        }

        public IUser Get(IUser user)
        {
            throw new NotImplementedException();
        }

        public void Update(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
