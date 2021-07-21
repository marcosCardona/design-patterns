
namespace AppPatronesDiseño.Patrones_comportamiento._10.Strategy
{
    public class TextProcess
    {
        private IFormatterStrategy _Formatter;

        public void SetFormatter(IFormatterStrategy formatter)
        {
            _Formatter = formatter;
        }

        public string Process()
        {
            return _Formatter.GetText();
        }
    }
}