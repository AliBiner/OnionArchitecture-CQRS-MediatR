using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace OnionArchitecture_CQRS_MediatR.Application.Features.Queries.GetProductById
{
    public class GetProductByIdMapping: Profile
    {
        public GetProductByIdMapping()
        {
            CreateMap<Domain.Entities.Product, GetProductByIdViewModel>().ReverseMap();
        }
    }
}
