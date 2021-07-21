
namespace AppPatronesDiseño.Patrones_comportamiento._1.ChainResponsability
{
    public class MassiveSpecification : ISpecification
    {
        public bool IsSatisfied(int smsCount)
        {
            return (smsCount >= 100);
        }
    }
}