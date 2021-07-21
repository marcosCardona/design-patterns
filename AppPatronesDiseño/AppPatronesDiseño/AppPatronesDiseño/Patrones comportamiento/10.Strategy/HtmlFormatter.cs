using System.Text;

namespace AppPatronesDiseño.Patrones_comportamiento._10.Strategy
{
    public class HtmlFormatterStrategy : IFormatterStrategy
    {
        private StringBuilder _HtmlText;

        /// <summary>
        /// Constructor
        /// </summary>
        public HtmlFormatterStrategy()
        {
            _HtmlText = new StringBuilder();
        }

        public string GetText()
        {
            return _HtmlText.ToString();
        }

        public void Start()
        {
            _HtmlText.Append("<html>");
        }

        public void Middle(string value)
        {
            _HtmlText.Append("<body>");
            _HtmlText.Append(value);
            _HtmlText.Append("</body>");
        }
        
        public void End()
        {
            _HtmlText.Append("</html>");
        }
    }
}