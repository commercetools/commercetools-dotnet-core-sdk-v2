using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class TransitionLineItemStateChange : ITransitionLineItemStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IItemState> PreviousValue { get; set; }
        public IEnumerable<IItemState> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IItemState> NextValue { get; set; }
        public IEnumerable<IItemState> NextValueEnumerable { set => NextValue = value.ToList(); }


        public string LineItemId { get; set; }

        public string StateId { get; set; }
        public TransitionLineItemStateChange()
        {
            this.Type = "TransitionLineItemStateChange";
        }
    }
}
