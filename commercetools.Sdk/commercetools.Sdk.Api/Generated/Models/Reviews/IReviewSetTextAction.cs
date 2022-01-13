using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetTextAction))]
    public partial interface IReviewSetTextAction : IReviewUpdateAction
    {
        string Text { get; set; }
    }
}
