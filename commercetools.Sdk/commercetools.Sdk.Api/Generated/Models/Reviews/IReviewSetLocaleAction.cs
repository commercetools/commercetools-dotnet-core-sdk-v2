using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetLocaleAction))]
    public partial interface IReviewSetLocaleAction : IReviewUpdateAction
    {
        string Locale { get; set; }

    }
}
