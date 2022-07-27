using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingMethodTaxAmountChange : ISetShippingMethodTaxAmountChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxMode TaxMode { get; set; }

        public IShippingMethodTaxAmountChangeValue NextValue { get; set; }

        public IShippingMethodTaxAmountChangeValue PreviousValue { get; set; }
        public SetShippingMethodTaxAmountChange()
        {
            this.Type = "SetShippingMethodTaxAmountChange";
        }
    }
}
