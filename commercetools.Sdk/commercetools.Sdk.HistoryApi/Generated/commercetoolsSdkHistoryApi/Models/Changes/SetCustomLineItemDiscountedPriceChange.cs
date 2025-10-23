using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetCustomLineItemDiscountedPriceChange : ISetCustomLineItemDiscountedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public IDiscountedLineItemPrice PreviousValue { get; set; }

        public IDiscountedLineItemPrice NextValue { get; set; }
        public SetCustomLineItemDiscountedPriceChange()
        {
            this.Type = "SetCustomLineItemDiscountedPriceChange";
        }
    }
}
