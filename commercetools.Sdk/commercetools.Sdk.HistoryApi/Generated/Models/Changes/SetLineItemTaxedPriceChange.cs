using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetLineItemTaxedPriceChange : ISetLineItemTaxedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string LineItemId { get; set; }

        public ITaxedItemPrice NextValue { get; set; }

        public ITaxedItemPrice PreviousValue { get; set; }
        public SetLineItemTaxedPriceChange()
        {
            this.Type = "SetLineItemTaxedPriceChange";
        }
    }
}
