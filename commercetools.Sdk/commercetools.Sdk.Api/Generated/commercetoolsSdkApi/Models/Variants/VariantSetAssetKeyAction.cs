

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetAssetKeyAction : IVariantSetAssetKeyAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }
        public VariantSetAssetKeyAction()
        {
            this.Action = "setAssetKey";
        }
    }
}
