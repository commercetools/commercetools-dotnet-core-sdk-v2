using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetCustomLineItemDiscountedPricePerQuantityChange : ISetCustomLineItemDiscountedPricePerQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public IDiscountedLineItemPriceForQuantity PreviousValue { get; set; }

        public IDiscountedLineItemPriceForQuantity NextValue { get; set; }
        public SetCustomLineItemDiscountedPricePerQuantityChange()
        {
            this.Type = "SetCustomLineItemDiscountedPricePerQuantityChange";
        }
    }
}
