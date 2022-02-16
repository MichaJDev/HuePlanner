using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Guests.Interface
{
    public interface IGuest
    {
        public string GetName();

        public string GetFirstName();

        public DateTime GetDayOfBirth();   

        public void SetName(string name);

        public void SetFirstName(string firstName);

        public void SetDayOfBirth(DateTime date);    

    }
}
