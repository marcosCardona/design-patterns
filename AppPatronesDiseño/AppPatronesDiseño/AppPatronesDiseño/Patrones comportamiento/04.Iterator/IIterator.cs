
namespace AppPatronesDiseño.Patrones_comportamiento._4.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}