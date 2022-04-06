using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetCustomLineItemTaxedPriceChange : ISetCustomLineItemTaxedPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public IMoney NextValue { get; set; }

        public IMoney PreviousValue { get; set; }
        public SetCustomLineItemTaxedPriceChange()
        {
            this.Type = "SetCustomLineItemTaxedPriceChange";
        }
    }
}
