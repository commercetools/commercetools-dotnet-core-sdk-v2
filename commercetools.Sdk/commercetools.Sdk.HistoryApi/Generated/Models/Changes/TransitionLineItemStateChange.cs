using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class TransitionLineItemStateChange : ITransitionLineItemStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string LineItemId { get; set; }

        public string StateId { get; set; }

        public IList<IItemState> NextValue { get; set; }
        public IEnumerable<IItemState> NextValueEnumerable { set => NextValue = value.ToList(); }


        public IList<IItemState> PreviousValue { get; set; }
        public IEnumerable<IItemState> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public TransitionLineItemStateChange()
        {
            this.Type = "TransitionLineItemStateChange";
        }
    }
}
