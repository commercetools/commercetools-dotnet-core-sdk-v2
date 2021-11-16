using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewReference))]
    public partial interface IReviewReference : IReference
    {
        IReview Obj { get; set;}
    }
}
