using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetAuthorNameAction))]
    public partial interface IReviewSetAuthorNameAction : IReviewUpdateAction
    {
        string AuthorName { get; set; }

    }
}
