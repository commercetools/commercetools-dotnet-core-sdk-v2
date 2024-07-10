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

    public partial class SetLineItemTaxedPriceChange : ISetLineItemTaxedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxedItemPrice PreviousValue { get; set; }

        public ITaxedItemPrice NextValue { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string LineItemId { get; set; }
        public SetLineItemTaxedPriceChange()
        {
            this.Type = "SetLineItemTaxedPriceChange";
        }
    }
}
