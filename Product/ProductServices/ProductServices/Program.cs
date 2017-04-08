using Mono.Unix;
using Mono.Unix.Native;
using Nancy.Hosting.Self;
using System;
using log4net;
using System.Configuration;

namespace ProductServices
{
    class Program
    {
        private static ILog m_log;

        static void Main(string[] args)
        {
            m_log = LogManager.GetLogger("ProductService");

            var uri = ConfigurationManager.AppSettings["listeningUri"];

            m_log.Info(String.Format("Starting ProductService on {0}", uri));

            // initialize an instance of NancyHost
            var config = new HostConfiguration();
            config.UrlReservations.CreateAutomatically = true;

            var host = new NancyHost(config, new Uri(uri));
            host.Start();  // start hosting

            // check if we're running on mono
            if (Type.GetType("Mono.Runtime") != null)
            {
                // on mono, processes will usually run as daemons - this allows you to listen
                // for termination signals (ctrl+c, shutdown, etc) and finalize correctly
                UnixSignal.WaitAny(new[] {
                    new UnixSignal(Signum.SIGINT),
                    new UnixSignal(Signum.SIGTERM),
                    new UnixSignal(Signum.SIGQUIT),
                    new UnixSignal(Signum.SIGHUP)
                });
            }
            else
            {   
                Console.ReadLine();
            }

            host.Stop();  // stop hosting
            m_log.Info(String.Format("ProductService Stop on {0}", uri));

        }
    }
}
