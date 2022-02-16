using HuePlanner.Logic.DTOS.Todos.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Todos
{
    public class ToDo : IToDo
    {
        private string name = "";
        private DateTime deadline;
        private string description = "";

        public DateTime GetDeadline()
        {
           return deadline;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetName()
        {
            return name;
        }

        public void SetDeadline(DateTime args)
        {
            deadline = args;
        }

        public void SetDescription(string args)
        {
            description = args;
        }

        public void SetName(string args)
        {
            name = args;
        }
    }
}
