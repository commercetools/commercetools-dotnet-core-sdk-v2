using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetLineItemProductSlugChange : ISetLineItemProductSlugChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString LineItem { get; set; }

        public string Variant { get; set; }

        public ILocalizedString NextValue { get; set; }

        public ILocalizedString PreviousValue { get; set; }
        public SetLineItemProductSlugChange()
        {
            this.Type = "SetLineItemProductSlugChange";
        }
    }
}
