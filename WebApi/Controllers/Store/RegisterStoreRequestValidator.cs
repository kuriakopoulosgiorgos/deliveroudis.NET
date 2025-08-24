using FluentValidation;

namespace WebApi.Controllers.Store;

public class RegisterStoreRequestValidator : AbstractValidator<RegisterStoreRequest>
{
    public RegisterStoreRequestValidator()
    {
        RuleFor(x => x.Name).MinimumLength(3)
            .WithMessage(p => $"{nameof(p.Name)} must be at least 3 characters long");
    }
}
