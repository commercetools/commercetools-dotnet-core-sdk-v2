using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ResourceSizeLimitExceededError))]
    public partial interface IResourceSizeLimitExceededError : IErrorObject
    {
    }
}
