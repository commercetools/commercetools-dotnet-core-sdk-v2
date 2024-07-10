using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ReturnInfo))]
    public partial interface IReturnInfo
    {
        IList<IReturnItem> Items { get; set; }
        IEnumerable<IReturnItem> ItemsEnumerable { set => Items = value.ToList(); }


        string ReturnTrackingId { get; set; }

        string ReturnDate { get; set; }

    }
}
