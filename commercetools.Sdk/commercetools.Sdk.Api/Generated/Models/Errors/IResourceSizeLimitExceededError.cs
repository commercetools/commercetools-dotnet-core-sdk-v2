using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ResourceSizeLimitExceededError))]
    public partial interface IResourceSizeLimitExceededError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
