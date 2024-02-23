using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicatePriceScopeError))]
    public partial interface IDuplicatePriceScopeError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IPrice ConflictingPrice { get; set; }

    }
}
