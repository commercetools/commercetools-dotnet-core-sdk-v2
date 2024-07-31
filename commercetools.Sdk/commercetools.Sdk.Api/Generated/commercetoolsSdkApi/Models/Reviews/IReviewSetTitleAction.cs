using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetTitleAction))]
    public partial interface IReviewSetTitleAction : IReviewUpdateAction
    {
        string Title { get; set; }

    }
}
