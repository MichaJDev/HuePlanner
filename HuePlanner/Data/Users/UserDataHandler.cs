using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Users;
using HuePlanner.Logic.DTOS.Users.Interface;
using MySql.Data.MySqlClient;

namespace HuePlanner.Data.Users
{
    internal class UserDataHandler : IUserDataHandler
    {
        private string conString = "Server=localhost;Port=3306;Database=huedb;Uid=root;Pwd=;";
        public void Create(IUser user)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "INSERT INTO `users` (uuid, username,password,email,name,surname) VALUES (@uuid, @username,@password,@email,@name,@surname)";


                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@uuid", MySqlDbType.VarChar);
                command.Parameters.Add("@username", MySqlDbType.VarChar);
                command.Parameters.Add("@password", MySqlDbType.VarChar);
                command.Parameters.Add("@email", MySqlDbType.VarChar);
                command.Parameters.Add("@name", MySqlDbType.VarChar);
                command.Parameters.Add("@surname", MySqlDbType.VarChar);

                command.Parameters["@uuid"].Value = user.GetUUID();
                command.Parameters["@username"].Value = user.GetUserName();
                command.Parameters["@password"].Value = user.GetPassword();
                command.Parameters["@email"].Value = user.GetEmail();
                var firstWord = user.GetName().Split(' ').FirstOrDefault();
                command.Parameters["@name"].Value = firstWord;
                var secondWord = user.GetName().Split(' ').Skip(1).FirstOrDefault();
                command.Parameters["@surname"].Value = secondWord;
                con.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
                con.Close();

            }
        }

        public void Delete(IUser user)
        {
            throw new NotImplementedException();
        }

        public IUser Get(IUser user)
        {
            IUser nUser = new User();
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * FROM Users WHERE email = @email";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@email", MySqlDbType.VarChar);
                command.Parameters["@email"].Value = user.GetEmail();

                con.Open();
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    user.SetUUID(sqlReader.GetString(1));
                    List<IUser> friends = new List<IUser>();
                    nUser = new User(sqlReader.GetInt32(0),
                        sqlReader.GetString(1),
                        sqlReader.GetString(5),
                        sqlReader.GetString(6),
                        sqlReader.GetString(2),
                        sqlReader.GetString(3),
                        sqlReader.GetString(4),
                        false, friends
                        );
                    con.Close();
                    return nUser;

                }
            }
            return nUser;
        }
        private IUser GetByUUID(IUser user)
        {
            IUser nUser = Get(user);
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * FROM Users WHERE uuid = @uuid";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@uuid", MySqlDbType.VarChar);
                command.Parameters["@uuid"].Value = user.GetUUID();
                MySqlDataReader sqlReader = command.ExecuteReader();
                con.Open();
                while (sqlReader.Read())
                {
                    user.SetUUID(sqlReader.GetString(1));
                    nUser = new User(sqlReader.GetInt32(0),
                        sqlReader.GetString(1),
                        sqlReader.GetString(5),
                        sqlReader.GetString(6),
                        sqlReader.GetString(2),
                        sqlReader.GetString(3),
                        sqlReader.GetString(4),
                        false
                        );
                    return nUser;

                }
            }
            return nUser;
        }
        public void Update(IUser user)
        {
            throw new NotImplementedException();
        }

        public bool IsAdmin(IUser user)
        {
            bool isAdmin = false;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT COUNT(*) FROM Admins WHERE uuid = @uuid";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add("@uuid", MySqlDbType.VarChar);
                cmd.Parameters["@uuid"].Value = user.GetUUID();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count < 0)
                    return true;
                return false;
            }
            return isAdmin;
        }
    }
}
