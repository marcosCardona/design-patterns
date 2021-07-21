using System;
using System.Collections.Generic;

namespace AppPatronesDiseño.Patrones_estructurales._3.Composite
{
    public class UserCComposite : AbstractUserC
    {
        private List<AbstractUserC> _listUserC = new List<AbstractUserC>();

        /// <summary>
        /// Constructor
        /// </summary>
        public UserCComposite() : base(0, DateTime.MinValue)
        {
        }

        public override void Add(AbstractUserC abstractUserC)
        {
            _listUserC.Add(abstractUserC);
        }

        public override void Remove(AbstractUserC abstractUserC)
        {
            _listUserC.Remove(abstractUserC);
        }

        public override int Count()
        {
            return _listUserC.Count;
        }
    }
}