using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetLocaleAction))]
    public partial interface IReviewSetLocaleAction : IReviewUpdateAction
    {
        string Locale { get; set; }
    }
}
