namespace USP.Application.Common.Dto;

public record ProductDetailsDto(string Name, decimal Price, string Description, UserDetailsDto ReferencedOneToOneUser, ListUserDetailsDto ReferencedOneToManyUsers, ListUserDetailsDto ReferencedManyToManyUsers);