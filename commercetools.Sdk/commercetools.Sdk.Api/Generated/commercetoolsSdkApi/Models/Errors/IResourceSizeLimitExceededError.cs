using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ResourceSizeLimitExceededError))]
    public partial interface IResourceSizeLimitExceededError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
