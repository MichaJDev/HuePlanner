using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.DTOS.Todos.Interface
{
    public interface IToDo
    {
        public void SetName(string args);

        public void SetDeadline(DateTime args);

        public void SetDescription(string args);

        public string GetName();

        public string GetDescription();

        public DateTime GetDeadline();

    }
}
