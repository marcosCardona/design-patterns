
namespace AppPatronesDiseño.Patrones_comportamiento._1.ChainResponsability
{
    public abstract class Handler
    {
        protected Handler _Successor;
        protected ISpecification _Specification;

        /// <summary>
        /// Constructor
        /// </summary>
        public Handler(ISpecification specification)
        {
            _Specification = specification;
        }

        public void SetSuccessor(Handler successor)
        {
            _Successor = successor;
        }

        public abstract void HandleRequest(ISmsRequest smsRequest);
    }
}