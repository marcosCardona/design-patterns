using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace AppPatronesDiseño.Patrones_estructurales._1.Adapter
{
    public class AdapterDetail : ITypeDetailConverter
    {
        private Detail _detail;

        /// <summary>
        /// Constructor
        /// </summary>
        public AdapterDetail(Detail detail)
        {
            _detail = detail;
        }

        public XDocument StringToXDocument()
        {
            if (_detail.TypeDetail == EnumTypeDetail.XML)
                return XDocument.Parse(_detail.CrudeDetail);
            else
                return null;
        }

        public JObject StringToJObject()
        {
            if (_detail.TypeDetail == EnumTypeDetail.JSON)
                return JObject.Parse(_detail.CrudeDetail);
            else
                return null;
        }
    }
}