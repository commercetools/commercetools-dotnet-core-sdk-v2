using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
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
