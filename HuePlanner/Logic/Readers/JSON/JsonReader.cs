using HuePlanner.Logic.DTOS.Items.JSON;
using HuePlanner.Logic.Readers.JSON.Interface;
using System.Text.Json;

namespace HuePlanner.Logic.Readers.JSON
{
    public class JsonReader : IJsonReader
    {
        public JsonItem DeserializeFile(string path)
        {
            string jsonString = File.ReadAllText(path);
            JsonItem item = JsonSerializer.Deserialize<JsonItem>(jsonString)!;
            return item;
        }
    }
}
