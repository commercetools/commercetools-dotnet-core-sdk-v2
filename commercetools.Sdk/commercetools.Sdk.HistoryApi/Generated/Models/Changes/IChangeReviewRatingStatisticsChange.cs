using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeReviewRatingStatisticsChange))]
    public partial interface IChangeReviewRatingStatisticsChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        IReviewRatingStatistics NextValue { get; set;}
        
        IReviewRatingStatistics PreviousValue { get; set;}
    }
}
