using Application.Stores.RegisterStore;
using Domain.Stores;

namespace Application.Stores;

public class StoreCommandHandler(IStoreRepository storeRepository)
{
    public async Task<Guid> Handle(RegisterStoreCommand registerStoreCommand)
    {
        var store = new Store
        {
            Reference = Guid.NewGuid(),
            Name = registerStoreCommand.Name,
        };
        await storeRepository.Save(store);
        return store.Reference;
    }
}
