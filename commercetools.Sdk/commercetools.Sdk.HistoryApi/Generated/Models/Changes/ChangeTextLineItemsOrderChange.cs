using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeTextLineItemsOrderChange : IChangeTextLineItemsOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<ITextLineItemValue> PreviousValue { get; set; }

        public List<ITextLineItemValue> NextValue { get; set; }
        public ChangeTextLineItemsOrderChange()
        {
            this.Type = "ChangeTextLineItemsOrderChange";
        }
    }
}
