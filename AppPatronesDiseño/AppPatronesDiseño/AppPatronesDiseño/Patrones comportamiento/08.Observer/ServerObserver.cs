using System.Collections.Generic;

namespace AppPatronesDiseño.Patrones_comportamiento._8.Observer
{
    public class ServerObserver
    {
        private List<Server> _ListServers;

        public ServerObserver()
        {
            _ListServers = new List<Server>();
        }

        public void Add(Server server)
        {
            _ListServers.Add(server);
        }

        public void Remove(Server server)
        {
            _ListServers.Remove(server);
        }

        public void Process()
        {
            foreach (var server in _ListServers)
                server.UpdateLog();
        }
    }
}