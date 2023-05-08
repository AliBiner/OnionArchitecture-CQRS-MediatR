using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture_CQRS_MediatR.Application.Interfaces.Repository;
using OnionArchitecture_CQRS_MediatR.Persistance.Context;
using OnionArchitecture_CQRS_MediatR.Persistance.Repositories;

namespace OnionArchitecture_CQRS_MediatR.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("MemoryDatabase"));
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
