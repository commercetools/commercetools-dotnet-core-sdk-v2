

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantRemoveAssetAction : IVariantRemoveAssetAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }
        public VariantRemoveAssetAction()
        {
            this.Action = "removeAsset";
        }
    }
}
