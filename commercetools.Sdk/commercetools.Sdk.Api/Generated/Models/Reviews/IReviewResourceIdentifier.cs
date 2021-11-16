using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewResourceIdentifier))]
    public partial interface IReviewResourceIdentifier : IResourceIdentifier
    {
    }
}
