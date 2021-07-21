using System;

namespace AppPatronesDiseño.Patrones_estructurales._3.Composite
{
    public class UserC : AbstractUserC
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UserC(int id, DateTime lastLogIn) : base(id, lastLogIn)
        {
        }

        public override void Add(AbstractUserC abstractUserC)
        {
            throw new NotImplementedException();
        }

        public override void Remove(AbstractUserC abstractUserC)
        {
            throw new NotImplementedException();
        }

        public override int Count()
        {
            throw new NotImplementedException();
        }
    }
}