using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeCustomLineItemPriceRoundingModeChange : IChangeCustomLineItemPriceRoundingModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public IRoundingMode PreviousValue { get; set; }

        public IRoundingMode NextValue { get; set; }
        public ChangeCustomLineItemPriceRoundingModeChange()
        {
            this.Type = "ChangeCustomLineItemPriceRoundingModeChange";
        }
    }
}
