using Application.Stores.GetStore;
using Domain.BusinessException;

namespace Application.Stores;

public sealed class StoreQueryHandler(IStoreRepository repository)
{
    private const string StoreNotFound =  "Store not found";
    public async Task<StoreDto> Handle(GetStoreQuery getStoreQuery)
    {
        var store = await repository.FindStoreAsync(getStoreQuery.Reference) ?? throw new EntityNotFoundException(StoreNotFound);
        return new StoreDto(store.Reference, store.Name);
    }
}
