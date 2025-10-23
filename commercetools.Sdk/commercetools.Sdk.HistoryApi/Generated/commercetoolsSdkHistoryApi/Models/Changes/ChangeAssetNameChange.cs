using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeAssetNameChange : IChangeAssetNameChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString PreviousValue { get; set; }

        public ILocalizedString NextValue { get; set; }

        public IAssetChangeValue Asset { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }
        public ChangeAssetNameChange()
        {
            this.Type = "ChangeAssetNameChange";
        }
    }
}
