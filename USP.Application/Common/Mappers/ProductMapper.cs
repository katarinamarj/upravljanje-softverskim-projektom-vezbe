using Riok.Mapperly.Abstractions;
using USP.Application.Common.Dto;

namespace USP.Application.Common.Mappers;

[Mapper]
public static partial class ProductMapper
{
    
    public static partial ProductDetailsDto ToDto(this Domain.Entities.Product entity);

    public static ProductCustomDetailsDto ToCustomDto(this Domain.Entities.Product entity)
    {
        return new ProductCustomDetailsDto(entity.Name + " - " + entity.Price);
    }

    public static partial Domain.Entities.Product ToEntitiyFromCreateDto(this ProductCreateDto dto);
    
}