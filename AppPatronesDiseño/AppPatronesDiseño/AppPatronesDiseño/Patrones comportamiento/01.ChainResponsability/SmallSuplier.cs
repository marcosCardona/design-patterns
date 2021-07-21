using System;

namespace AppPatronesDiseño.Patrones_comportamiento._1.ChainResponsability
{
    public class SmallSuplier : Handler
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SmallSuplier(ISpecification specification) : base(specification)
        {
        }

        public override void HandleRequest(ISmsRequest smsRequest)
        {
            if (base._Specification.IsSatisfied(smsRequest.SmsCount()))
                Console.WriteLine("Send messages from SmallSuplier");
            else
                base._Successor.HandleRequest(smsRequest);
        }
    }
}