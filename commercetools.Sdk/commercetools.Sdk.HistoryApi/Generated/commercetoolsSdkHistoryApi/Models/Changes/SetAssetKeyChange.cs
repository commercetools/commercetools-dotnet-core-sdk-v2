using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAssetKeyChange : ISetAssetKeyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }

        public IAssetChangeValue Asset { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }
        public SetAssetKeyChange()
        {
            this.Type = "SetAssetKeyChange";
        }
    }
}
