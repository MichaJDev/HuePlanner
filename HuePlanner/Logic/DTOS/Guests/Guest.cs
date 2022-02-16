using HuePlanner.Logic.DTOS.Guests.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Guests
{
    public class Guest : IGuest
    {
        private string name = "";
        private string firstName = "";
        private DateTime dateOfBirth;

        public DateTime GetDayOfBirth()
        {
            throw new NotImplementedException();
        }

        public string GetFirstName()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public void SetDayOfBirth(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void SetFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
