using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace Resume.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logPath = Path.Combine(Directory.GetCurrentDirectory(), "Files/Logs");
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(logPath + "/Service_Log_.txt",
                    rollingInterval: RollingInterval.Day,
                    fileSizeLimitBytes: 1_000_000,
                    rollOnFileSizeLimit: true,
                    shared: true,
                    flushToDiskInterval: TimeSpan.FromSeconds(1)
                )
                .WriteTo.Console()
                .CreateLogger();
            try
            {
                Log.Information("Starting web host");
                CreateHostBuilder(args).UseSerilog().Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
