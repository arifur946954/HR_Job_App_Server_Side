using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CTG_ERPWebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder//.UseKestrel(options => { options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(3600); options.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(3600); options.Limits.MaxRequestBodySize = 4000000000; })
                             .UseContentRoot(Directory.GetCurrentDirectory())
                             .UseSetting("detailedErrors", "true")
                             .UseIISIntegration()
                             .UseStartup<Startup>()
                             .UseUrls("http://localhost:3000")
                             .CaptureStartupErrors(true);
                    //.Build();
                });

        //public static void Main(string[] args)
        //{
        //    BuildWebHost(args).Run();
        //}

        //public static IWebHost BuildWebHost(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseKestrel(options => { options.Limits.KeepAliveTimeout = TimeSpan.FromMinutes(3600); options.Limits.RequestHeadersTimeout = TimeSpan.FromMinutes(3600); options.Limits.MaxRequestBodySize = 4000000000; })
        //         .UseContentRoot(Directory.GetCurrentDirectory())
        //         .UseSetting("detailedErrors", "true")
        //         .UseIISIntegration()
        //         .UseStartup<Startup>()
        //         .UseUrls("http://localhost:3000")
        //         .CaptureStartupErrors(true)
        //         .Build();
    }
}
