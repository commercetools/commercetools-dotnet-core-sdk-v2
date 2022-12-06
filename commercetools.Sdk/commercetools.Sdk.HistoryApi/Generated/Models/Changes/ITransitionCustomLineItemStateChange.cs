using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.TransitionCustomLineItemStateChange))]
    public partial interface ITransitionCustomLineItemStateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string LineItemId { get; set; }

        string StateId { get; set; }

        IList<IItemState> NextValue { get; set; }
        IEnumerable<IItemState> NextValueEnumerable { set => NextValue = value.ToList(); }


        IList<IItemState> PreviousValue { get; set; }
        IEnumerable<IItemState> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


    }
}
