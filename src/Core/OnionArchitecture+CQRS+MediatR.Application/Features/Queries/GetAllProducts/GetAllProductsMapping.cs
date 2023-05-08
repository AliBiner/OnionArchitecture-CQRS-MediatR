using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace OnionArchitecture_CQRS_MediatR.Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsMapping: Profile
    {
        public GetAllProductsMapping()
        {
            CreateMap<Domain.Entities.Product, Dto.ProductViewDto>().ReverseMap();
        }
    }
}
