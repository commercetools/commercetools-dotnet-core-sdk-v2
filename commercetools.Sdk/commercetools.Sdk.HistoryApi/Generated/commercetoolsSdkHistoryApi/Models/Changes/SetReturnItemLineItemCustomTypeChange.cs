using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetReturnItemLineItemCustomTypeChange : ISetReturnItemLineItemCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string Variant { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string LineItemId { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetReturnItemLineItemCustomTypeChange()
        {
            this.Type = "SetReturnItemLineItemCustomTypeChange";
        }
    }
}
