using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
