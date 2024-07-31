using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessagePayload))]
    public partial interface IReviewCreatedMessagePayload : IMessagePayload
    {
        IReview Review { get; set; }

    }
}
