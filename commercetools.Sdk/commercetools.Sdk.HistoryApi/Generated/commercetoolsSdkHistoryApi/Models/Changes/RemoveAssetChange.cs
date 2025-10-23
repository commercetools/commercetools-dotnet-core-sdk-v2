using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveAssetChange : IRemoveAssetChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAsset PreviousValue { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }
        public RemoveAssetChange()
        {
            this.Type = "RemoveAssetChange";
        }
    }
}
