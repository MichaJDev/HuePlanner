using HuePlanner.Logic.DTOS.Locations.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Locations
{
    public class Location : ILocation
    {
        private string name = "";

        private string street = "";

        private int number;

        private char addition;

        private string postalCode = "";

        private string townShip = "";

        public char GetAddition()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public int GetNumber()
        {
            throw new NotImplementedException();
        }

        public string GetPostalCode()
        {
            throw new NotImplementedException();
        }

        public string GetStreet()
        {
            throw new NotImplementedException();
        }

        public string GetTownShip()
        {
            throw new NotImplementedException();
        }

        public void SetAddition(char args)
        {
            throw new NotImplementedException();
        }

        public void SetName(string args)
        {
            throw new NotImplementedException();
        }

        public void SetNumber(int args)
        {
            throw new NotImplementedException();
        }

        public void SetPostalCode(string args)
        {
            throw new NotImplementedException();
        }

        public void SetStreet(string args)
        {
            throw new NotImplementedException();
        }

        public void SetTownShip(string args)
        {
            throw new NotImplementedException();
        }
    }
}
