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
        public string ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
