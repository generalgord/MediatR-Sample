using MediatR;

using MediatRSample.Operations.Commands;
using MediatRSample.Operations.Queries;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatRSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery(id);
            return Ok(await mediator.Send(query));
        }


        [HttpGet]
        public async Task<IActionResult> GetAll(Guid id)
        {
            var query = new GetAllProductsQuery();
            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> PostProduct(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }
    }
}
