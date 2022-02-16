using HuePlanner.Logic.DTOS.Items.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuePlanner.Logic.Readers.JSON.Interface
{
    public interface IJsonReader
    {
        public JsonItem DeserializeFile(string path);
    }
}
