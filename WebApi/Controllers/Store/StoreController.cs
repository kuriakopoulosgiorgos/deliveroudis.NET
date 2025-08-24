using Application.Stores;
using Application.Stores.GetStore;
using Application.Stores.RegisterStore;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.Store;

[ApiController]
[Route("api/stores")]
public class StoreController(StoreCommandHandler storeCommandHandler, StoreQueryHandler storeQueryHandler) : ControllerBase
{

    [HttpPost]
    public async Task<RegisterStoreResponse> RegisterStore([FromBody] RegisterStoreRequest registerStoreRequest)
    {
        var reference = await storeCommandHandler.Handle(new RegisterStoreCommand(registerStoreRequest.Name));
        return new RegisterStoreResponse(reference);
    }

    [HttpGet("{reference:guid}")]
    public async Task<StoreDto> GetStore([FromRoute] Guid reference)
    {
        return await storeQueryHandler.Handle(new GetStoreQuery(reference));
    }
    
}
