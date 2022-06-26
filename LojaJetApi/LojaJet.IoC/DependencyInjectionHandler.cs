using LojaJet.BLL.Infra.Services.Interfaces;
using LojaJet.BLL.Services;
using LojaJet.Repository.Infra.Repositories.Interfaces;
using LojaJet.Repository.Repositories;
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
            services.AddScoped<IProductRepository, ProductRepository>();
            #endregion

            #region Business
            services.AddScoped<IProductService, ProductService>();
            #endregion
            return services;
        }
    }
}
