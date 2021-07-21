using System;

namespace AppPatronesDiseño.Patrones_estructurales._3.Composite
{
    public abstract class AbstractUserC
    {
        public int Id { get; set; }
        public DateTime LastLogIn { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public AbstractUserC(int id, DateTime lastLogIn)
        {
            Id = id;
            LastLogIn = lastLogIn;
        }

        public abstract void Add(AbstractUserC abstractUserC);
        public abstract void Remove(AbstractUserC abstractUserC);
        public abstract int Count();
    }
}