using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCustomLineItemCustomTypeChange : ISetCustomLineItemCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public ICustomFields NextValue { get; set; }

        public ICustomFields PreviousValue { get; set; }
        public SetCustomLineItemCustomTypeChange()
        {
            this.Type = "SetCustomLineItemCustomTypeChange";
        }
    }
}
