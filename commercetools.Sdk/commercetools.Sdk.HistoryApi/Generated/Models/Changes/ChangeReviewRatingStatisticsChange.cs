using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeReviewRatingStatisticsChange : IChangeReviewRatingStatisticsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReviewRatingStatistics NextValue { get; set; }

        public IReviewRatingStatistics PreviousValue { get; set; }
        public ChangeReviewRatingStatisticsChange()
        {
            this.Type = "ChangeReviewRatingStatisticsChange";
        }
    }
}
