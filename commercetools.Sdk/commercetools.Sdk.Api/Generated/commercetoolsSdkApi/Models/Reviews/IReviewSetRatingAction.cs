using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetRatingAction))]
    public partial interface IReviewSetRatingAction : IReviewUpdateAction
    {
        int? Rating { get; set; }

    }
}
