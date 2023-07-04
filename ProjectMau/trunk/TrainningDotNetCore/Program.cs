
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace TrainningDotNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
          //  CreateWebHostBuilder(args)
          //      .CaptureStartupErrors(true)
         //       .UseSetting("detailedErrors","true")
         //       .Build()
         //       .Run();

            new WebHostBuilder()
       .UseKestrel()
       .UseContentRoot(Directory.GetCurrentDirectory())
       .UseStartup<Startup>()
       .Build()
       .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseIISIntegration()
                .UseStartup<Startup>();
    }
}
