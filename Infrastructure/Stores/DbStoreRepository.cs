using Application.Stores;
using Domain.Stores;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Stores;

public class DbStoreRepository(DeliveroudisDbContext dbContext) : IStoreRepository
{
    
    public async Task<Store?> FindStoreAsync(Guid storeReference)
    {
        return await dbContext.Stores.FirstOrDefaultAsync(s => s.Reference == storeReference);
    }

    public async Task Save(Store store)
    {
        await dbContext.Stores.AddAsync(store);
        await dbContext.SaveChangesAsync();
    }
}
