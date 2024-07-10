using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetTextAction))]
    public partial interface IReviewSetTextAction : IReviewUpdateAction
    {
        string Text { get; set; }

    }
}
