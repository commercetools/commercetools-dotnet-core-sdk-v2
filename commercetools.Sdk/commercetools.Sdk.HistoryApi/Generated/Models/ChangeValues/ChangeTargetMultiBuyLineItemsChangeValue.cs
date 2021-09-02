using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    public partial class ChangeTargetMultiBuyLineItemsChangeValue : IChangeTargetMultiBuyLineItemsChangeValue
    {
        public string Type { get; set; }

        public string Predicate { get; set; }

        public int TriggerQuantity { get; set; }

        public int DiscountedQuantity { get; set; }

        public int MaxOccurrence { get; set; }

        public ISelectionMode SelectionMode { get; set; }
        public ChangeTargetMultiBuyLineItemsChangeValue()
        {
            this.Type = "multiBuyLineItems";
        }
    }
}
