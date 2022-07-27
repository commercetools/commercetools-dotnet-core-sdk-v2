using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeCustomLineItemQuantityChange : IChangeCustomLineItemQuantityChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public int NextValue { get; set; }

        public int PreviousValue { get; set; }
        public ChangeCustomLineItemQuantityChange()
        {
            this.Type = "ChangeCustomLineItemQuantityChange";
        }
    }
}
