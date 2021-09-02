using commercetools.HistoryApi.Models.ChangeValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeTargetCustomLineItemsChangeValue : IChangeTargetCustomLineItemsChangeValue
    {
        public string Type { get; set; }

        public string Predicate { get; set; }
        public ChangeTargetCustomLineItemsChangeValue()
        {
            this.Type = "customLineItems";
        }
    }
}
