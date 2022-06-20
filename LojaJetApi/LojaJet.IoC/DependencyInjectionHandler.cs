using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaJet.IoC
{
    public static class DependencyInjectionHandler
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            #region Repository
            #endregion

            #region Business
            #endregion
            return services;
        }
    }
}
