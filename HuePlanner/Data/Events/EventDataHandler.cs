using HuePlanner.Data.Events.Interfaces;
using HuePlanner.Data.Users;
using HuePlanner.Data.Users.Interface;
using HuePlanner.Logic.DTOS.Consumables;
using HuePlanner.Logic.DTOS.Consumables.Interface;
using HuePlanner.Logic.DTOS.Enums.EditTypes.Parties;
using HuePlanner.Logic.DTOS.Enums.Packaging;
using HuePlanner.Logic.DTOS.Parties;
using HuePlanner.Logic.DTOS.Parties.Interface;
using HuePlanner.Logic.DTOS.Todos;
using HuePlanner.Logic.DTOS.Todos.Interface;
using HuePlanner.Logic.DTOS.Users;
using HuePlanner.Logic.DTOS.Users.Interface;
using MySql.Data.MySqlClient;

namespace HuePlanner.Data.Events
{
    public class EventDataHandler : IEventDataHandler
    {
        private string conString = "Server=localhost;Port=3306;Database=huedb;Uid=root;Pwd=;";
        private IUserDataHandler userData = new UserDataHandler();
        public void Create(IParty p)
        {
            IParty party = new Party();
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "INSERT INTO 'events' (eventid, name,description,budget,startDate,endDate,strictStartDate,strictEndDate,owner) VALUES (@eventid, @name,@description,@budget,@startDate,@endDate,@strictStartDate,@strictEndDate, @owner)";

                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@eventid", MySqlDbType.VarChar);
                command.Parameters.Add("@name", MySqlDbType.VarChar);
                command.Parameters.Add("@description", MySqlDbType.Text);
                command.Parameters.Add("@budget", MySqlDbType.Double);
                command.Parameters.Add("@startDate", MySqlDbType.VarChar);
                command.Parameters.Add("@endDate", MySqlDbType.VarChar);
                command.Parameters.Add("@strictStartDate", MySqlDbType.Bit);
                command.Parameters.Add("@strictEndDate", MySqlDbType.Bit);
                command.Parameters.Add("@owner", MySqlDbType.VarChar);

                command.Parameters["@eventid"].Value = Guid.NewGuid().ToString();
                command.Parameters["@name"].Value = p.Name;
                command.Parameters["@description"].Value = p.Description;
                command.Parameters["@budget"].Value = p.Budget;
                command.Parameters["@startDate"].Value = p.StartTime.ToString();
                command.Parameters["@endDate"].Value = p.EndTime.ToString();
                command.Parameters["@strictStartDate"].Value = p.StrictStartTime;
                command.Parameters["@strictEndDate"].Value = p.StrictEndTime;
                command.Parameters["@owner"].Value = p.Owner;
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

        public void Delete(IParty p)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "DELETE FROM events WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }

        public IParty Get(IParty p)
        {
            IParty party = new Party();
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;
                con.Open();
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    party.ID = sqlReader.GetString(1);
                    party.Name = sqlReader.GetString(2);
                    party.Description = sqlReader.GetString(3);
                    party.Budget = sqlReader.GetDouble(4);
                    party.StartTime = DateTime.Parse(sqlReader.GetString(5));
                    party.EndTime = DateTime.Parse(sqlReader.GetString(6));
                    party.StrictStartTime = sqlReader.GetBoolean(7);
                    party.StrictEndTime = sqlReader.GetBoolean(8);
                    party.Owner = sqlReader.GetString(9);
                    party.Invited = GetInvited(p);
                    party.Confirmed = GetConfirmed(p);
                    party.Declined = GetDeclined(p);
                    party.Consumables = GetConsumables(p);
                }

                return party;
            }
        }

        public List<IParty> GetOwned(IUser user)
        {
            IUser knownUser = userData.Get(user);
            List<IParty> ownedParties = new List<IParty>();
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * FROM events WHERE owner = @owner";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@owner", MySqlDbType.VarChar);
                command.Parameters["@owner"].Value = knownUser.GetUUID();
                con.Open();

                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    IParty party = new Party();
                    party.ID = sqlReader.GetString(1);
                    party.Name = sqlReader.GetString(2);
                    party.Description = sqlReader.GetString(3);

                    ownedParties.Add(party);
                }
                return ownedParties;
            }
        }

        public List<IUser> GetInvited(IParty p)
        {
            List<IUser> invited = new List<IUser>();

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * FROM eventconfirmedmembers WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;
                con.Open();
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    IUser userUUID = new User();
                    userUUID.SetUUID(sqlReader.GetString(1));
                    IUser user = userData.Get(userUUID);
                    invited.Add(user);
                }

            }
            return invited;
        }

        public void Update(PartyEditType type, IParty p)
        {
            string query = "";
            switch (type)
            {
                case PartyEditType.NAME:
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        query = "UPDATE FROM events SET name = @name WHERE eventid = @id";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.Add("@name", MySqlDbType.VarChar);
                        command.Parameters.Add("@id", MySqlDbType.VarChar);
                        command.Parameters["@name"].Value = p.Name;
                        command.Parameters["@id"].Value = p.ID;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    break;
                case PartyEditType.DESCRIPTION:
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        query = "UPDATE FROM events SET description = @desc WHERE eventid = @id";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.Add("@desc", MySqlDbType.VarChar);
                        command.Parameters.Add("@id", MySqlDbType.VarChar);
                        command.Parameters["@desc"].Value = p.Description;
                        command.Parameters["@id"].Value = p.ID;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }

                    break;
                case PartyEditType.BUDGET:

                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        query = "UPDATE FROM events SET budget = @budget WHERE eventid = @id";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.Add("@budget", MySqlDbType.Double);
                        command.Parameters.Add("@id", MySqlDbType.VarChar);
                        command.Parameters["@budget"].Value = p.Name;
                        command.Parameters["@id"].Value = p.ID;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    break;
                case PartyEditType.STARTTIME:
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        query = "UPDATE FROM events SET startDate = @start WHERE eventid = @id";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.Add("@start", MySqlDbType.VarChar);
                        command.Parameters.Add("@id", MySqlDbType.VarChar);
                        command.Parameters["@start"].Value = p.StartTime.ToString(); ;
                        command.Parameters["@id"].Value = p.ID;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    break;
                case PartyEditType.ENDTIME:
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        query = "UPDATE FROM events SET endDate = @end WHERE eventid = @id";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.Add("@end", MySqlDbType.VarChar);
                        command.Parameters.Add("@id", MySqlDbType.VarChar);
                        command.Parameters["@end"].Value = p.EndTime.ToString();
                        command.Parameters["@id"].Value = p.ID;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }

                    break;
                case PartyEditType.STRICTSTARTTIME:
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        query = "UPDATE FROM events SET strictStartDate = @strictStart WHERE eventid = @id";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.Add("@strictStart", MySqlDbType.Byte);
                        command.Parameters.Add("@id", MySqlDbType.VarChar);
                        command.Parameters["@strictStart"].Value = p.StrictStartTime;
                        command.Parameters["@id"].Value = p.ID;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    break;
                case PartyEditType.STRICTENDTIME:
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        query = "UPDATE FROM events SET strictEndDate = @strictEnd WHERE eventid = @id";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.Add("@strictEnd", MySqlDbType.Byte);
                        command.Parameters.Add("@id", MySqlDbType.VarChar);
                        command.Parameters["@strictEnd"].Value = p.StrictEndTime;
                        command.Parameters["@id"].Value = p.ID;
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    break;
                case PartyEditType.OWNER:
                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        query = "UPDATE FROM events SET owner = @owner WHERE eventid = @id";
                        MySqlCommand command = new MySqlCommand(query, con);
                        command.Parameters.Add("@owner", MySqlDbType.VarChar);
                        command.Parameters.Add("@id", MySqlDbType.VarChar);
                        command.Parameters["@owner"].Value = p.Owner;
                        command.Parameters["@id"].Value = p.ID;

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }
                    break;


            }
        }

        public List<IUser> GetConfirmed(IParty p)
        {
            List<IUser> confirmed = new List<IUser>();

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * FROM eventconfirmedmembers WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;
                con.Open();
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    IUser userUUID = new User();
                    userUUID.SetUUID(sqlReader.GetString(1));
                    IUser user = userData.Get(userUUID);
                    confirmed.Add(user);
                }
                return confirmed;
            }
        }

        public List<IUser> GetDeclined(IParty p)
        {
            List<IUser> declined = new List<IUser>();

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * FROM eventdeclinedmembers WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;
                con.Open();
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    IUser userUUID = new User();
                    userUUID.SetUUID(sqlReader.GetString(1));
                    IUser user = userData.Get(userUUID);
                    declined.Add(user);
                }
                return declined;
            }
        }

        public List<IToDo> GetTodos(IParty p)
        {
            List<IToDo> todos = new List<IToDo>();

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * FROM todos WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;
                con.Open();
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    IToDo todo = new ToDo();
                    todo.Name = sqlReader.GetString(2);
                    todo.Description = sqlReader.GetString(3);
                    todo.IsCompleted = sqlReader.GetBoolean(5);
                    todos.Add(todo);
                }
                return todos;
            }
        }

        public List<IConsumable> GetConsumables(IParty p)
        {
            List<IConsumable> consumables = new List<IConsumable>();

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                string query = "SELECT * FROM consumables WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;
                con.Open();
                MySqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    IConsumable consumable = new Consumable();
                    consumable.Name = sqlReader.GetString(2);
                    consumable.Packaging = GetPackagingType(sqlReader.GetString(3));
                    consumables.Add(consumable);
                }
                return consumables;
            }
        }

        public PackagingType GetPackagingType(string var)
        {
            switch (var)
            {
                case "CARTON":
                    return PackagingType.CARTON;

                case "ALLUMINUM":
                    return PackagingType.ALLUMINUM;

                case "STEEL":
                    return PackagingType.STEEL;

                case "PLASTIC":
                    return PackagingType.PLASTIC;

                default:
                    return PackagingType.CARTON;
            }
        }

        public void UpdateTodos(IParty p)
        {
            string query;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                query = "UPDATE FROM todos SET name = @name, description = @desc, completed = @completed WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@name", MySqlDbType.VarChar);
                command.Parameters.Add("@desc", MySqlDbType.Text);
                command.Parameters.Add("@completed", MySqlDbType.Byte);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                foreach (IToDo t in p.Todos)
                {
                    command.Parameters["@name"].Value = t.Name;
                    command.Parameters["@desc"].Value = t.Description;
                    command.Parameters["@completed"].Value = t.IsCompleted;
                    command.Parameters["@id"].Value = p.ID;
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        }

        public void UpdateConfirmed(IParty p)
        {
            string query;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                query = "SELECT COUNT(*) FROM eventconfirmedmembers WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;

                int countCurrent = (int)command.ExecuteScalar();
                if (p.Confirmed.Count > countCurrent)
                {
                    query = "SELECT * FROM eventconfirmedmembers WHERE eventid = @id";
                    command.CommandText = query;
                    MySqlDataReader sqlReader = command.ExecuteReader();
                    int i = 0;
                    while (sqlReader.Read())
                    {
                        foreach (IUser user in p.Confirmed)
                        {
                            if (!(user.GetUUID() == sqlReader.GetString(1)))
                            {
                                query = "INSERT INTO eventconfirmedmembers (eventid, uuid) VALUES (@id, @uuid)";
                                command.CommandText = query;
                                command.Parameters.Add("@id", MySqlDbType.VarChar);
                                command.Parameters.Add("@uuid", MySqlDbType.VarChar);
                                foreach (IUser u in p.Confirmed)
                                {
                                    command.Parameters["@id"].Value = p.ID;
                                    command.Parameters["@uuid"].Value = u.GetUUID();

                                    try
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                    catch (MySqlException e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void UpdateDeclined(IParty p)
        {
            string query;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                query = "SELECT COUNT(*) FROM eventdeclinedmembers WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;

                int countCurrent = (int)command.ExecuteScalar();
                if (p.Declined.Count > countCurrent)
                {
                    query = "SELECT * FROM eventdeclinedmembers WHERE eventid = @id";
                    command.CommandText = query;
                    MySqlDataReader sqlReader = command.ExecuteReader();
                    int i = 0;
                    while (sqlReader.Read())
                    {
                        foreach (IUser user in p.Declined)
                        {
                            if (!(user.GetUUID() == sqlReader.GetString(1)))
                            {
                                query = "INSERT INTO eventdeclinedmembers (eventid, uuid) VALUES (@id, @uuid)";
                                command.CommandText = query;
                                command.Parameters.Add("@id", MySqlDbType.VarChar);
                                command.Parameters.Add("@uuid", MySqlDbType.VarChar);
                                foreach (IUser u in p.Declined)
                                {
                                    command.Parameters["@id"].Value = p.ID;
                                    command.Parameters["@uuid"].Value = u.GetUUID();

                                    try
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                    catch (MySqlException e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void UpdateInvited(IParty p)
        {
            string query;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                query = "SELECT COUNT(*) FROM eventmembers WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;

                int countCurrent = (int)command.ExecuteScalar();
                if (p.Invited.Count > countCurrent)
                {
                    query = "SELECT * FROM eventmembers WHERE eventid = @id";
                    command.CommandText = query;
                    MySqlDataReader sqlReader = command.ExecuteReader();
                    int i = 0;
                    while (sqlReader.Read())
                    {
                        foreach (IUser user in p.Invited)
                        {
                            if (!(user.GetUUID() == sqlReader.GetString(1)))
                            {
                                query = "INSERT INTO eventmembers (eventid, uuid) VALUES (@id, @uuid)";
                                command.CommandText = query;
                                command.Parameters.Add("@id", MySqlDbType.VarChar);
                                command.Parameters.Add("@uuid", MySqlDbType.VarChar);
                                foreach (IUser u in p.Invited)
                                {
                                    command.Parameters["@id"].Value = p.ID;
                                    command.Parameters["@uuid"].Value = u.GetUUID();

                                    try
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                    catch (MySqlException e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void UpdateConsumables(IParty p)
        {
            string query;
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                query = "SELECT COUNT(*) FROM consumables WHERE eventid = @id";
                MySqlCommand command = new MySqlCommand(query, con);
                command.Parameters.Add("@id", MySqlDbType.VarChar);
                command.Parameters["@id"].Value = p.ID;

                int countCurrent = (int)command.ExecuteScalar();
                if (p.Confirmed.Count > countCurrent)
                {
                    query = "SELECT * FROM consumables WHERE eventid = @id";
                    command.CommandText = query;
                    MySqlDataReader sqlReader = command.ExecuteReader();
                    int i = 0;
                    while (sqlReader.Read())
                    {
                        foreach (Consumable c in p.Consumables)
                        {
                            if (!(c.Id == sqlReader.GetInt32(0)))
                            {
                                query = "INSERT INTO consumables (eventid, name,type) VALUES (@id, @name,@type)";
                                command.CommandText = query;
                                command.Parameters.Add("@id", MySqlDbType.Int32);
                                command.Parameters.Add("@name", MySqlDbType.VarChar);
                                command.Parameters.Add("@type", MySqlDbType.VarChar);
                                foreach (Consumable cons in p.Confirmed)
                                {
                                    command.Parameters["@id"].Value = p.ID;
                                    command.Parameters["@name"].Value = cons.Name;
                                    command.Parameters["@type"].Value = cons.Packaging.ToString();

                                    try
                                    {
                                        command.ExecuteNonQuery();
                                    }
                                    catch (MySqlException e)
                                    {
                                        Console.WriteLine(e.ToString());
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
