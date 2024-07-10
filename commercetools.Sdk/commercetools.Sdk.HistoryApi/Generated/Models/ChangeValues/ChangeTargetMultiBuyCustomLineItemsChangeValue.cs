using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{

    public partial class ChangeTargetMultiBuyCustomLineItemsChangeValue : IChangeTargetMultiBuyCustomLineItemsChangeValue
    {
        public string Type { get; set; }

        public string Predicate { get; set; }

        public int TriggerQuantity { get; set; }

        public int DiscountedQuantity { get; set; }

        public int MaxOccurrence { get; set; }

        public ISelectionMode SelectionMode { get; set; }
        public ChangeTargetMultiBuyCustomLineItemsChangeValue()
        {
            this.Type = "multiBuyCustomLineItems";
        }
    }
}
