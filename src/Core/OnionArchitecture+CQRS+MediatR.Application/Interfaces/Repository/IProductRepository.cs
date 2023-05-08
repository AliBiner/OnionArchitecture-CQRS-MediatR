using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture_CQRS_MediatR.Domain.Entities;

namespace OnionArchitecture_CQRS_MediatR.Application.Interfaces.Repository
{
    public interface IProductRepository : IGenericRepositoryAsync<Product>
    {
        
    }
}
