using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace AppPatronesDiseño.Patrones_estructurales._1.Adapter
{
    public interface ITypeDetailConverter
    {
        XDocument StringToXDocument();
        JObject StringToJObject();
    }
}