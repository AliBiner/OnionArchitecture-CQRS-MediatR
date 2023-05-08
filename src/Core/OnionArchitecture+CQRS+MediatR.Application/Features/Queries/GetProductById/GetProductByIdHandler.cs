using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using OnionArchitecture_CQRS_MediatR.Application.Dto;
using OnionArchitecture_CQRS_MediatR.Application.Interfaces.Repository;
using OnionArchitecture_CQRS_MediatR.Application.Wrapper;

namespace OnionArchitecture_CQRS_MediatR.Application.Features.Queries.GetProductById
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdViewModel>>
    {
        private IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetProductByIdHandler(IProductRepository productRepository,IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<GetProductByIdViewModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByIdAsync(request.Id);
            var viewModel = mapper.Map<GetProductByIdViewModel>(product);

            return new ServiceResponse<GetProductByIdViewModel>(viewModel);
        }
    }
}
