using System.Xml.Linq;

namespace AppPatronesDiseño.Patrones_estructurales._2.Bridge
{
    public class XmlFormatter : IFormatter
    {
        public string Format(string value)
        {
            if (!string.IsNullOrEmpty(value))
                return XElement.Parse(value).ToString();

            return value;
        }
    }
}