using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingInfoDiscountedPriceChange : ISetShippingInfoDiscountedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDiscountedLineItemPrice PreviousValue { get; set; }

        public IDiscountedLineItemPrice NextValue { get; set; }
        public SetShippingInfoDiscountedPriceChange()
        {
            this.Type = "SetShippingInfoDiscountedPriceChange";
        }
    }
}
