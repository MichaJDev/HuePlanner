using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Enums.EditTypes.Parties
{
    public enum PartyEditType
    {
        NAME,
        DESCRIPTION, 
        BUDGET, 
        STARTTIME, 
        ENDTIME, 
        STRICTSTARTTIME, 
        STRICTENDTIME, 
        TODOS,
        INVITED,
        CONFIRMED,
        DECLINED,
        CONSUMABLES,
        OWNER
    }
}
