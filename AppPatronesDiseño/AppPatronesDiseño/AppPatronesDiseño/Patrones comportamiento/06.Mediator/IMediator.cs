using System.Threading.Tasks;

namespace AppPatronesDiseño.Patrones_comportamiento._6.Mediator
{
    public interface IMediator
    {
        bool IsAvailable();
        Task ProcessAsync();
    }
}