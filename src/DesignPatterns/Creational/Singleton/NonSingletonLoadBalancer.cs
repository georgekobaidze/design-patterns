using System.Collections.Generic;

namespace DesignPatterns.Creational.Singleton
{
    public class NonSingletonLoadBalancer
    {
        private readonly List<Server> _servers;

        private int nextServer = 0;

        public NonSingletonLoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Name = "Server 1", Ip = "97.14.121.55" },
                new Server{ Name = "Server 2", Ip = "97.14.121.56" },
                new Server{ Name = "Server 3", Ip = "97.14.121.57" },
                new Server{ Name = "Server 4", Ip = "97.14.121.58" },
                new Server{ Name = "Server 5", Ip = "97.14.121.59" }
            };
        }

        public Server NextServer
        {
            get
            {
                var server = _servers[nextServer % _servers.Count];
                nextServer++;
                return server;
            }
        }
    }
}
