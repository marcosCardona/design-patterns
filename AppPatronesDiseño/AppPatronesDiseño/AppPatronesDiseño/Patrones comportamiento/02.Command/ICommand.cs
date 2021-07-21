
namespace AppPatronesDiseño.Patrones_comportamiento._2.Command
{
    public interface ICommand
    {
        void Invoke();
        void SetAction(EnumAction action);
    }
}