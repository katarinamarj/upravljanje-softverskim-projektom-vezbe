using Microsoft.AspNetCore.Mvc;
using USP.Application.Product.Commands;
using USP.Application.Product.Queries;

namespace USP.API.Controllers;

public class ProductController : ApiBaseController
{
    
    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] GetOneProductQuery query) => Ok(await Mediator.Send(query));

    [HttpGet]
    public async Task<ActionResult> GetAll() => Ok(await Mediator.Send(new GetAllProductQuery()));

    [HttpPost]
    public async Task<ActionResult> Create(CreateProductCommand command) => Ok(await Mediator.Send(command));
}