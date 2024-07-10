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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetSupplyChannelsChange))]
    public partial interface ISetSupplyChannelsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IReference> PreviousValue { get; set; }
        IEnumerable<IReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IReference> NextValue { get; set; }
        IEnumerable<IReference> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
