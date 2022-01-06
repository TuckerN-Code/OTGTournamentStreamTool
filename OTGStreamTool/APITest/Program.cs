using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OTGStreamToolBackEnd;

namespace APITest
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Global.update = new UpdatePackage();
            Global.packageID = 0;
            FillGlobal();
           
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseUrls("https://localhost:5549");
                });

        public static void FillGlobal()
        {
            Global.update.Player1Tag = "Celsus";
            Global.update.Player1Score = "2";
            Global.update.Player2Score = "0";
            Global.update.Player2Tag = "D5";
        }
    }

}
