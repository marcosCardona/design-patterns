using System.Text;

namespace AppPatronesDiseño.Patrones_comportamiento._10.Strategy
{
    public class XmlFormatterStrategy : IFormatterStrategy
    {
        private StringBuilder _XmlText;

        /// <summary>
        /// Constructor
        /// </summary>
        public XmlFormatterStrategy()
        {
            _XmlText = new StringBuilder();
        }

        public string GetText()
        {
            return _XmlText.ToString();
        }

        public void Start()
        {
            _XmlText.Append("<xml>");
        }

        public void Middle(string value)
        {
            _XmlText.Append("<value>");
            _XmlText.Append(value);
            _XmlText.Append("</value>");
        }

        public void End()
        {
            _XmlText.Append("</xml>");
        }
    }
}