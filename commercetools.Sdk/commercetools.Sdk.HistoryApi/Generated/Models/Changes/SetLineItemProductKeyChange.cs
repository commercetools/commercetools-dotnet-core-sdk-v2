using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetLineItemProductKeyChange : ISetLineItemProductKeyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string LineItemId { get; set; }

        public string Variant { get; set; }
        public SetLineItemProductKeyChange()
        {
            this.Type = "SetLineItemProductKeyChange";
        }
    }
}
