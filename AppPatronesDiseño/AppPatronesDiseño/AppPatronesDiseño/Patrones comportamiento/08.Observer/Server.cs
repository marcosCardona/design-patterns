using System;

namespace AppPatronesDiseño.Patrones_comportamiento._8.Observer
{
    public class Server
    {
        private string _AdminEmail;

        /// <summary>
        /// Constructor
        /// </summary>
        public Server(string email)
        {
            _AdminEmail = email;
        }

        public void UpdateLog()
        {
            // Load text from log and count errors
            var hasErrors = true;

            if (hasErrors)
                SendEmail();
        }

        public void SendEmail()
        {
            // Send Email to Admin
            Console.WriteLine($"Sending email to admin: {_AdminEmail}");
        }
    }
}