using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
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
