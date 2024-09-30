using Microsoft.AspNetCore.Mvc;
using USP.Application.Product.Commands;
using USP.Application.Product.Queries;

namespace USP.API.Controllers;

public class ProductController : ApiBaseController
{
    
    [HttpGet]
    public async Task<string> Get() => await Mediator.Send(new GetOneProductQuery());


    [HttpPost]
    public async Task<string> Create(CreateProductCommand command) => await Mediator.Send(command);
}