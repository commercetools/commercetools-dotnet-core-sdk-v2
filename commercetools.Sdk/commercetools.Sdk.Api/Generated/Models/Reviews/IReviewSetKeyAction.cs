using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetKeyAction))]
    public partial interface IReviewSetKeyAction : IReviewUpdateAction
    {
        string Key { get; set;}
    }
}
