using commercetools.Sdk.HistoryApi.Models.Common;


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

        public string LineItemId { get; set; }
        public SetLineItemDiscountedPriceChange()
        {
            this.Type = "SetLineItemDiscountedPriceChange";
        }
    }
}
