using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewResourceIdentifier))]
    public partial interface IReviewResourceIdentifier : IResourceIdentifier
    {
    }
}
