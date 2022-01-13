using commercetools.Api.Models.Reviews;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ReviewCreatedMessagePayload))]
    public partial interface IReviewCreatedMessagePayload : IMessagePayload
    {
        IReview Review { get; set; }
    }
}
