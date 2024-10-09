using MongoDB.Entities;
using Riok.Mapperly.Abstractions;
using USP.Application.Common.Dto;
using USP.Domain.Entities;

namespace USP.Application.Common.Mappers;

[Mapper]
public static partial class UserMapper
{
    public static partial UserDetailsDto ToDto(this Domain.Entities.User entity);
    public static partial Domain.Entities.User ToEntity(this UserDetailsDto dto);
public static partial Domain.Entities.User ToEntity(this EditUserDto dto);
    
    
    public static ListUserDetailsDto ToListDto(this Many<Domain.Entities.User, Domain.Entities.Product> manyEntities)
    {
        var listDto = new List<UserDetailsDto>();

        foreach (var entity in manyEntities)
        {
            listDto.Add(entity.ToDto());
        }

        return new ListUserDetailsDto(listDto);
    }
}