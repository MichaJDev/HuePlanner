using HuePlanner.Logic.DTOS.Items.JSON;
using HuePlanner.Logic.Readers.JSON.Interface;
using Newtonsoft.Json;

namespace HuePlanner.Logic.Readers.JSON
{
    public class JsonReader : IJsonReader
    {
        public JsonItem DeserializeFile(string path)
        {
            using(StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                List<string> items = JsonConvert.DeserializeObject<List<string>>(json);
                JsonItem jItem = new JsonItem(items.First(), items.ElementAt(1), items.ElementAt(2), items.ElementAt(3));
                return jItem;
            }
        }
    }
}
