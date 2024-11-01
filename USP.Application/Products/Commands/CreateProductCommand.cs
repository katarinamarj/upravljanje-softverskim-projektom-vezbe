
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
        var userEntity = new Domain.Entities.User
        {
            Email = "katarina.marjanovic.21@singimail.rs",
            FirstName = "Katarina",
            LastName = "Marjanovic",
        };
        var userEntity2 = new Domain.Entities.User
        {
            Email = "ana21@singimail.rs",
            FirstName = "Ana",
            LastName = "A",
        };

        await userEntity.SaveAsync(cancellation: cancellationToken);
        await userEntity2.SaveAsync(cancellation: cancellationToken);


        var entity = request.Product.ToEntitiyFromCreateDto(userEntity, new One<Domain.Entities.User>(userEntity), [userEntity2, userEntity]);
        await entity.SaveAsync(cancellation:cancellationToken);
        await entity.ReferencedOneToManyUser.AddAsync([userEntity2, userEntity], cancellation: cancellationToken);
        var dto = entity.ToDtoAsync();
        return await dto;
    }
    
}