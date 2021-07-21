
namespace AppPatronesDiseño.Patrones_comportamiento._7.NullObject
{
    public class NullOperation : IOperation
    {
        public static readonly NullOperation Instance = null;

        public void Process()
        {
        }
    }
}