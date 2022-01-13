using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetShippingInfoTaxedPriceChange : ISetShippingInfoTaxedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxedPrice NextValue { get; set; }

        public ITaxedPrice PreviousValue { get; set; }
        public SetShippingInfoTaxedPriceChange()
        {
            this.Type = "SetShippingInfoTaxedPriceChange";
        }
    }
}
