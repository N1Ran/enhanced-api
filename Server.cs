using Nancy.Hosting.Self;
using NLog;
using System;

namespace Enhanced_API {
    public class Server
    {
        private readonly string url = "http://localhost";
        private readonly int port = 8081;
        private readonly NancyHost nancy;
        public static Logger Log = LogManager.GetLogger("EnhancedAPI");

        public Server()
        {
            var uri = new Uri($"{url}:{port}/");
            var configuration = new HostConfiguration()
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            nancy = new NancyHost(configuration, uri);
        }

        public void Start()
        {
            nancy.Start();
            Log.Info($"Enhanced API listening port {port}");
        }

        public void Stop() {
            nancy.Stop();
        }
    }
}
