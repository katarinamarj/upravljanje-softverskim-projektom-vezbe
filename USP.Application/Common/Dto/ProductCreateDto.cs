namespace USP.Application.Common.Dto;

public record ProductCreateDto(string Name, decimal Price, string Description, int Category)
{
    public int Category { get; set; }
}