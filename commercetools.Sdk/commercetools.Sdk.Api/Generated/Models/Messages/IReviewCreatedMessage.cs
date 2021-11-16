using commercetools.Api.Models.Reviews;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ReviewCreatedMessage))]
    public partial interface IReviewCreatedMessage : IMessage
    {
        IReview Review { get; set;}
    }
}
