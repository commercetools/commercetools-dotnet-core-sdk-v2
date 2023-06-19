using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeReviewRatingStatisticsChange))]
    public partial interface IChangeReviewRatingStatisticsChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IReviewRatingStatistics PreviousValue { get; set; }

        IReviewRatingStatistics NextValue { get; set; }

    }
}
