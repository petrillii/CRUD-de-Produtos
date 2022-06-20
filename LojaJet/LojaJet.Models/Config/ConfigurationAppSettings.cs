using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.Models.Config
{
    public static class ConfigurationAppSettings
    {
        public static IConfiguration GetConfiguration =>
           new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();
    }
}
