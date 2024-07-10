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

    public partial class SetLineItemDiscountedPriceChange : ISetLineItemDiscountedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDiscountedLineItemPrice PreviousValue { get; set; }

        public IDiscountedLineItemPrice NextValue { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string Variant { get; set; }
        public SetLineItemDiscountedPriceChange()
        {
            this.Type = "SetLineItemDiscountedPriceChange";
        }
    }
}
