using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeTextLineItemsOrderChange : IChangeTextLineItemsOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<ITextLineItemValue> PreviousValue { get; set; }

        public IEnumerable<ITextLineItemValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<ITextLineItemValue> NextValue { get; set; }

        public IEnumerable<ITextLineItemValue> NextValueEnumerable { set => NextValue = value.ToList(); }
        public ChangeTextLineItemsOrderChange()
        {
            this.Type = "ChangeTextLineItemsOrderChange";
        }
    }
}
