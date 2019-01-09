using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ELK
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
           ///写到这里也可以
            //var config = new ConfigurationBuilder().AddJsonFile("host.json", optional: true)
            // .Build();
            //var host = new WebHostBuilder()
            //   .UseKestrel()
            //   .UseContentRoot(Directory.GetCurrentDirectory())
            //   .UseStartup<Startup>()
            //   .UseConfiguration(config)
            //   .Build();
            //host.Run();      
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseConfiguration(new ConfigurationBuilder().AddJsonFile("host.json", optional: true)//如果写到这里就代表指定环境的里面的ip，不然走默认的  默认自己规定
                .Build())
                .Build();
      
    }
}
