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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.TransitionLineItemStateChange))]
    public partial interface ITransitionLineItemStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IItemState> PreviousValue { get; set; }
        IEnumerable<IItemState> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IItemState> NextValue { get; set; }
        IEnumerable<IItemState> NextValueEnumerable { set => NextValue = value.ToList(); }


        string LineItemId { get; set; }

        string StateId { get; set; }

    }
}
