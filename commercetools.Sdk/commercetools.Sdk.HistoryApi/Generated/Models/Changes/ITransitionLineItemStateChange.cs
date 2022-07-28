using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.TransitionLineItemStateChange))]
    public partial interface ITransitionLineItemStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string LineItemId { get; set; }

        string StateId { get; set; }

        List<IItemState> NextValue { get; set; }

        List<IItemState> PreviousValue { get; set; }

    }
}
