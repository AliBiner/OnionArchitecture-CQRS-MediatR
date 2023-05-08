using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace OnionArchitecture_CQRS_MediatR.Application
{
    public static class ServiceRegistration
    {
        public static void AddAppplicationRegistration(this IServiceCollection serviceCollection)
        {
            var assembly = Assembly.GetExecutingAssembly();
            serviceCollection.AddAutoMapper(assembly);
            serviceCollection.AddMediatR(cfg=>cfg.RegisterServicesFromAssemblies(assembly));
        }
    }
}
