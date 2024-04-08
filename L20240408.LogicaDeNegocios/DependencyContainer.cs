using L20240408.AccesoADatos;
using L20240408.EntidadesDeNegocios;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20240408.LogicaDeNegocios
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDalDependecies(configuration);
            services.AddScoped<PersonaLBL>();
            return services;
        }
    }
}
