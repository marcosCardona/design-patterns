using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace AppPatronesDiseño.Patrones_estructurales._1.Adapter
{
    public class Detail
    {
        public string CrudeDetail { get; set; }
        public EnumTypeDetail TypeDetail { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Detail(string crudeDetail, EnumTypeDetail typeDetail)
        {
            CrudeDetail = crudeDetail;
            TypeDetail = typeDetail;
        }
    }
}