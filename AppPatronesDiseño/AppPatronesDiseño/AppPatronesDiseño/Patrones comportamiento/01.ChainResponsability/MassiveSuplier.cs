using System;

namespace AppPatronesDiseño.Patrones_comportamiento._1.ChainResponsability
{
    public class MassiveSuplier : Handler
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MassiveSuplier(ISpecification specification) : base(specification)
        {
        }

        public override void HandleRequest(ISmsRequest smsRequest)
        {
            if (base._Specification.IsSatisfied(smsRequest.SmsCount()))
                Console.WriteLine("Send messages from MassiveSuplier");
            else
                base._Successor.HandleRequest(smsRequest);
        }
    }
}