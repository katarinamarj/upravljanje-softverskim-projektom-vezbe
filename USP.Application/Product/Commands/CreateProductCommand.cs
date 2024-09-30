
using MongoDB.Entities;
using MediatR;
namespace USP.Application.Product.Commands;
public record CreateProductCommand(string Name, decimal Price, string Description) : IRequest<string>;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, string>
{        public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = new Domain.Entities.Product
        {
            Name = request.Name,
            Price = request.Price,
            Description = request.Description
        };
        
        await entity.SaveAsync(cancellation:cancellationToken);
        return "Created";
    }
    
}