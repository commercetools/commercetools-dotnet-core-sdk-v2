using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingInfoTaxedPriceChange : ISetShippingInfoTaxedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxedItemPrice PreviousValue { get; set; }

        public ITaxedItemPrice NextValue { get; set; }
        public SetShippingInfoTaxedPriceChange()
        {
            this.Type = "SetShippingInfoTaxedPriceChange";
        }
    }
}
