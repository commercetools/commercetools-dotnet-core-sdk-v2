using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewReference))]
    public partial interface IReviewReference : IReference
    {
        IReview Obj { get; set; }

        new string Id { get; set; }

    }
}
