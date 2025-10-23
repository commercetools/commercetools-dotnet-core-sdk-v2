using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetReturnItemCustomLineItemCustomTypeChange : ISetReturnItemCustomLineItemCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetReturnItemCustomLineItemCustomTypeChange()
        {
            this.Type = "SetReturnItemCustomLineItemCustomTypeChange";
        }
    }
}
