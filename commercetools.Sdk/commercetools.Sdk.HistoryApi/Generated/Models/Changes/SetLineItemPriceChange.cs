using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetLineItemPriceChange : ISetLineItemPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString LineItem { get; set; }

        public IPrice NextValue { get; set; }

        public IPrice PreviousValue { get; set; }
        public SetLineItemPriceChange()
        {
            this.Type = "SetLineItemPriceChange";
        }
    }
}
