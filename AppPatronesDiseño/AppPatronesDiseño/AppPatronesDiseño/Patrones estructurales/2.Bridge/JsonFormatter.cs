using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppPatronesDiseño.Patrones_estructurales._2.Bridge
{
    public class JsonFormatter : IFormatter
    {
        public string Format(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                var jObject = JObject.Parse(value);
                return JsonConvert.SerializeObject(jObject, Formatting.Indented);
            }

            return value;
        }
    }
}