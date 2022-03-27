using HuePlanner.Logic.DTOS.Users.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Data.Users.Interface
{
    public interface IUserDataHandler
    {
        public void Create(IUser user);
        public void Update(IUser user);
        public void Delete(IUser user);
        public IUser Get(IUser user);
        public IUser GetByUUID(string uuid);
        public DataSet GetDataSetAll();
        public List<IUser> GetAll();
    }
}
