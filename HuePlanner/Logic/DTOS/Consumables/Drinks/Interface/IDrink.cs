﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Consumables.Drinks.Interface
{
    internal interface IDrink
    {
        public int GetContent();

        public void SetContent(int content);
    }
}
