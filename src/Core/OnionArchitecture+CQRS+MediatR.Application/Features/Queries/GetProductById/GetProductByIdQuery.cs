using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using OnionArchitecture_CQRS_MediatR.Application.Dto;
using OnionArchitecture_CQRS_MediatR.Application.Wrapper;

namespace OnionArchitecture_CQRS_MediatR.Application.Features.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdViewModel>>
    {
        public Guid Id { get; set; }
    }
}
