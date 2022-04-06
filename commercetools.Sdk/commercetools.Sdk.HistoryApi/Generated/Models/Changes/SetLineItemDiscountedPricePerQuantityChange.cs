using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetLineItemDiscountedPricePerQuantityChange : ISetLineItemDiscountedPricePerQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string Variant { get; set; }

        public IDiscountedLineItemPriceForQuantity NextValue { get; set; }

        public IDiscountedLineItemPriceForQuantity PreviousValue { get; set; }
        public SetLineItemDiscountedPricePerQuantityChange()
        {
            this.Type = "SetLineItemDiscountedPricePerQuantityChange";
        }
    }
}
