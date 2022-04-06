using commercetools.Sdk.HistoryApi.Models.Common;
using System;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetShippingMethodTaxAmountChange : ISetShippingMethodTaxAmountChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxMode TaxMode { get; set; }

        public Object NextValue { get; set; }

        public Object PreviousValue { get; set; }
        public SetShippingMethodTaxAmountChange()
        {
            this.Type = "SetShippingMethodTaxAmountChange";
        }
    }
}
