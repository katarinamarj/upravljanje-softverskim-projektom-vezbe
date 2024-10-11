namespace USP.Application.Common.Interfaces;

public class IProductService
{
    public Task<List<Domain.Entities.Product>> GetAllProductsAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}