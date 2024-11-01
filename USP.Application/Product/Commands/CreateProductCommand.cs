
using MongoDB.Entities;
using MediatR;
using USP.Application.Common.Dto;
using USP.Application.Common.Mappers;

namespace USP.Application.Product.Commands;
public record CreateProductCommand(ProductCreateDto Product) : IRequest<string>, IRequest<ProductDetailsDto>;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDetailsDto>
{        public async Task<ProductDetailsDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var entity = request.Product.ToEntitiyFromCreateDto();
        await entity.SaveAsync(cancellation:cancellationToken);
        var dto = entity.ToDto();
        return dto;
    }
    
}