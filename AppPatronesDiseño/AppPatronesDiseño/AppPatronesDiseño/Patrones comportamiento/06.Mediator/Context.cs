using System;

namespace AppPatronesDiseño.Patrones_comportamiento._6.Mediator
{
    public class Context
    {
        private Action _Action;

        public void SetAction(Action action)
        {
            _Action = action;
        }

        public Action GetAction()
        {
            return _Action;
        }
    }
}