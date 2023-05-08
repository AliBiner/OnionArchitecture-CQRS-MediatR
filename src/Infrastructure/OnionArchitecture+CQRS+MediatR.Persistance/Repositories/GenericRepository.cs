using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionArchitecture_CQRS_MediatR.Application.Interfaces.Repository;
using OnionArchitecture_CQRS_MediatR.Domain.Common;
using OnionArchitecture_CQRS_MediatR.Persistance.Context;

namespace OnionArchitecture_CQRS_MediatR.Persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepositoryAsync<T> where T : BaseEntity
    {
        private readonly AppDbContext dbContext;
        public GenericRepository(AppDbContext dbContext)
        {
            this.dbContext= dbContext;
        }
        public async Task<T> AddAsync(T entitty)
        {
            await dbContext.Set<T>().AddAsync(entitty);
            await dbContext.SaveChangesAsync();
            return entitty;
        }

        public async Task<List<T>> GetAllAsync()
        {
            
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }
    }
}
