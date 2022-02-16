using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Locations.Interface
{
    public interface ILocation
    {

        public string GetName();

        public string GetStreet();

        public int GetNumber();

        public char GetAddition();

        public string GetPostalCode();

        public string GetTownShip();

        public void SetName(string args);

        public void SetStreet(string args);

        public void SetNumber(int args);

        public void SetAddition(char args);

        public void SetPostalCode(string args);

        public void SetTownShip(string args);
    }
}
