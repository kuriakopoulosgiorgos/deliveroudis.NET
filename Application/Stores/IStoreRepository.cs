using Domain.Stores;

namespace Application.Stores;

public interface IStoreRepository
{
    Task<Store?> FindStoreAsync(Guid storeReference);
    
    Task Save(Store store);
}
