
namespace AppPatronesDiseño.Patrones_comportamiento._5.Memento
{
    public class Memento<T>
    {
        public T Value { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Memento(T value) => Value = value;
    }
}