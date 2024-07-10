using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
