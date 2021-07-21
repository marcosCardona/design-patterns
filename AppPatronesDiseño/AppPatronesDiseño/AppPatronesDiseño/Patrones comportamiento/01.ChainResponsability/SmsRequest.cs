using System.Collections.Generic;

namespace AppPatronesDiseño.Patrones_comportamiento._1.ChainResponsability
{
    public class SmsRequest : ISmsRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SmsRequest(int quantity)
        {
            ListSms = new List<Sms>();

            var sms = new Sms() { PhoneNumber = "12345678", Message = "Test message" };
            for (int i = 0; i < quantity; i++)
            {
                ListSms.Add(sms);
            }
        }

        public List<Sms> ListSms { get; set; }

        public int SmsCount()
        {
            return ListSms.Count;
        }
    }

    public class Sms
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
    }
}