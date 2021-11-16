using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetRatingAction))]
    public partial interface IReviewSetRatingAction : IReviewUpdateAction
    {
        int? Rating { get; set; }
    }
}
