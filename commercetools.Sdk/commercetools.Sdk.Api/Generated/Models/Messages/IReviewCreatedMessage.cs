using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReviewCreatedMessage))]
    public partial interface IReviewCreatedMessage : IMessage
    {
        IReview Review { get; set; }

    }
}
