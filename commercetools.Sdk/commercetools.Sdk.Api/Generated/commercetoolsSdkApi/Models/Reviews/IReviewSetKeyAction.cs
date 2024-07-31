using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewSetKeyAction))]
    public partial interface IReviewSetKeyAction : IReviewUpdateAction
    {
        string Key { get; set; }

    }
}
