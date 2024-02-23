using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
