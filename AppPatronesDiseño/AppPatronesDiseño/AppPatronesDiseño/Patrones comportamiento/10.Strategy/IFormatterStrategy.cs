
namespace AppPatronesDiseño.Patrones_comportamiento._10.Strategy
{
    public interface IFormatterStrategy
    {
        string GetText();
        void Start();
        void Middle(string value);
        void End();
    }
}