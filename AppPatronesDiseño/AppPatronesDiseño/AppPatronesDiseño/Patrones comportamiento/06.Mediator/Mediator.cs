using System.Threading.Tasks;

namespace AppPatronesDiseño.Patrones_comportamiento._6.Mediator
{
    public class Mediator : IMediator
    {
        private Context _Context;
        private bool _Availability;

        /// <summary>
        /// Constructor
        /// </summary>
        public Mediator(Context context)
        {
            _Context = context;
            _Availability = true;
        }

        public bool IsAvailable()
        {
            return _Availability;
        }

        public async Task ProcessAsync()
        {
            if (_Availability)
            {
                // Not available
                _Availability = false;
                // Run Action
                await Task.Run(_Context.GetAction());
                // Available again
                _Availability = true;
            }
        }
    }
}