using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class TransitionCustomLineItemStateChange : ITransitionCustomLineItemStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IItemState> PreviousValue { get; set; }

        public IEnumerable<IItemState> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IItemState> NextValue { get; set; }

        public IEnumerable<IItemState> NextValueEnumerable { set => NextValue = value.ToList(); }

        public string LineItemId { get; set; }

        public string CustomLineItemId { get; set; }

        public string StateId { get; set; }
        public TransitionCustomLineItemStateChange()
        {
            this.Type = "TransitionCustomLineItemStateChange";
        }
    }
}
