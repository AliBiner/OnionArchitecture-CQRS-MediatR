﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnionArchitecture_CQRS_MediatR.Domain.Entities;

namespace OnionArchitecture_CQRS_MediatR.Persistance.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = Guid.NewGuid(), Name = "Pen", Value= 10, Quantity = 100 },
                new Product() { Id = Guid.NewGuid(), Name = "PaperA4", Value= 1, Quantity = 200 },
                new Product() { Id = Guid.NewGuid(), Name = "Book", Value= 30, Quantity = 500 }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
