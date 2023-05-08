using OnionArchitecture_CQRS_MediatR.Application.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture_CQRS_MediatR.Domain.Entities;
using OnionArchitecture_CQRS_MediatR.Persistance.Context;

namespace OnionArchitecture_CQRS_MediatR.Persistance.Repositories
{
    public class ProductRepository: GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbContext): base(dbContext)
        {
            
        }
    }
}
