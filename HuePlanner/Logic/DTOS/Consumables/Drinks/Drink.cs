using HuePlanner.Logic.DTOS.Consumables.Drinks.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Consumables.Drinks
{
    public class Drink : Consumable, IDrink
    {
        private int content;

        public int GetContent()
        {
            return content;
        }

        public void SetContent(int _content)
        {
            content = _content;
        }
    }
}
