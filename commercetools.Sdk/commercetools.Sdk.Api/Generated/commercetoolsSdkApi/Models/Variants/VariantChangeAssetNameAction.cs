using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantChangeAssetNameAction : IVariantChangeAssetNameAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public ILocalizedString Name { get; set; }
        public VariantChangeAssetNameAction()
        {
            this.Action = "changeAssetName";
        }
    }
}
