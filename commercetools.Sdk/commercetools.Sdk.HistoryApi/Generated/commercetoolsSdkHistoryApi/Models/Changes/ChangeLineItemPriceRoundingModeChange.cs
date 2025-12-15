using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLineItemPriceRoundingModeChange : IChangeLineItemPriceRoundingModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string Variant { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string LineItemId { get; set; }

        public IRoundingMode PreviousValue { get; set; }

        public IRoundingMode NextValue { get; set; }
        public ChangeLineItemPriceRoundingModeChange()
        {
            this.Type = "ChangeLineItemPriceRoundingModeChange";
        }
    }
}
