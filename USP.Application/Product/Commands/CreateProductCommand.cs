
using MongoDB.Entities;
using MediatR;
using USP.Application.Common.Dto;
using USP.Application.Common.Mappers;
using USP.Domain.Entities;

namespace USP.Application.Product.Commands;
public record CreateProductCommand(ProductCreateDto Product) : IRequest<string>, IRequest<ProductDetailsDto>;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDetailsDto>
{        public async Task<ProductDetailsDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var userEntity = new User
        {
            Email = "katarina.marjanovic.21@singimail.rs",
            FirstName = "Katarina",
            LastName = "Marjanovic",
        };

        await userEntity.SaveAsync(cancellation: cancellationToken);
        
        var entity = request.Product.ToEntitiyFromCreateDto(userEntity, new One<User>(userEntity));
        await entity.SaveAsync(cancellation:cancellationToken);
        var dto = entity.ToDto();
        return dto;
    }
    
}