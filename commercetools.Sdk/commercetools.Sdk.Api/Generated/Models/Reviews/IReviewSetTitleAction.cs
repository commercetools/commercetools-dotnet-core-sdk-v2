using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetTitleAction))]
    public partial interface IReviewSetTitleAction : IReviewUpdateAction
    {
        string Title { get; set; }
    }
}
