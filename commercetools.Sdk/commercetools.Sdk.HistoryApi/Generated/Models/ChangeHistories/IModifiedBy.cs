using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeHistories
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeHistories.ModifiedBy))]
    public partial interface IModifiedBy
    {
        string Id { get; set; }

        string Type { get; set; }

        string ClientId { get; set; }

        string AnonymousId { get; set; }

        IReference Customer { get; set; }

        IReference Associate { get; set; }

        bool IsPlatformClient { get; set; }

    }
}
