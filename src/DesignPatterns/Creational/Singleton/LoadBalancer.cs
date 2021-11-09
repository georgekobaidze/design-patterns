using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Singleton
{
    public sealed class LoadBalancer
    {
        private static readonly LoadBalancer _instance = new LoadBalancer();

        private readonly List<Server> _servers;

        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Name = "ServerI", Ip = "120.14.220.18" },
                new Server{ Name = "ServerII", Ip = "120.14.220.19" },
                new Server{ Name = "ServerIII", Ip = "120.14.220.20" },
                new Server{ Name = "ServerIV", Ip = "120.14.220.21" },
                new Server{ Name = "ServerV", Ip = "120.14.220.22" }
            };
        }

        public static LoadBalancer GetLoadBalancer() => _instance;

        public Server NextServer
        {
            get
            {
                int random = _random.Next(_servers.Count);
                return _servers[random];
            }
        }
    }
}
