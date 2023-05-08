using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitecture_CQRS_MediatR.Application.Interfaces.Repository;
using OnionArchitecture_CQRS_MediatR.Application.Dto;
using OnionArchitecture_CQRS_MediatR.Application.Features.Commands.CreateProduct;
using OnionArchitecture_CQRS_MediatR.Application.Features.Queries.GetAllProducts;
using OnionArchitecture_CQRS_MediatR.Application.Features.Queries.GetProductById;

namespace OnionArchitecture_CQRS_MediatR.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        private readonly IMediator mediator;

        public ProductController(IMediator mediator )
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };
            return Ok(await mediator.Send(query));

        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }

        
    }
}
