using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReviewRatingSetMessage))]
    public partial interface IReviewRatingSetMessage : IMessage
    {
        decimal? OldRating { get; set; }

        decimal? NewRating { get; set; }

        bool IncludedInStatistics { get; set; }

        IReference Target { get; set; }

    }
}
