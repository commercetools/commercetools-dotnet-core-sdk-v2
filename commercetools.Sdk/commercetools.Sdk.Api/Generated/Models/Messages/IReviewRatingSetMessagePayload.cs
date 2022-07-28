using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessagePayload))]
    public partial interface IReviewRatingSetMessagePayload : IMessagePayload
    {
        decimal? OldRating { get; set; }

        decimal? NewRating { get; set; }

        bool IncludedInStatistics { get; set; }

        IReference Target { get; set; }

    }
}
