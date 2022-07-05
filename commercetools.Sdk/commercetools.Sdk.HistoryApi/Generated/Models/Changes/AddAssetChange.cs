using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddAssetChange : IAddAssetChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAsset NextValue { get; set; }

        public IAsset PreviousValue { get; set; }
        public AddAssetChange()
        {
            this.Type = "AddAssetChange";
        }
    }
}
