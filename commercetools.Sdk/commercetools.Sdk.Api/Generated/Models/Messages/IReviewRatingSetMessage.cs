using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessage))]
    public partial interface IReviewRatingSetMessage : IMessage
    {
        double? OldRating { get; set; }

        double? NewRating { get; set; }

        bool IncludedInStatistics { get; set; }

        IReference Target { get; set; }
    }
}
