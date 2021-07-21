
namespace AppPatronesDiseño.Patrones_comportamiento._5.Memento
{
    interface IMementoAction<T>
    {
        T Undo();
        T Redo();
    }
}