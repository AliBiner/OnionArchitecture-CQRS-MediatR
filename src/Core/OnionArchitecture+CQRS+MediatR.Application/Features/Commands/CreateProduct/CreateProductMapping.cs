using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture_CQRS_MediatR.Application.Features.Commands.CreateProduct
{
    public class CreateProductMapping: Profile
    {
        public CreateProductMapping()
        {
            CreateMap<Domain.Entities.Product, CreateProductCommand>().ReverseMap();
        }

    }
}
