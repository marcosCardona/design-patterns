
namespace AppPatronesDiseño.Patrones_estructurales._2.Bridge
{
    public abstract class BridgeFormatter
    {
        protected IFormatter _iFormatter;

        /// <summary>
        /// Constructor
        /// </summary>
        public BridgeFormatter(IFormatter iFormatter)
        {
            _iFormatter = iFormatter;
        }

        public abstract string FormatString();
    }
}