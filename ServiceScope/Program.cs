using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

// Master
// https://www.youtube.com/watch?v=01C8selSVCY&list=PLLDRFIlohka8uZI7MhOg8YeJY7yAfHi2v
// https://github.com/T0shik/RawCoding_ServiceScope

// https://endjin.com/blog/2022/09/service-lifetimes-in-aspnet-core


namespace ServiceScope
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
