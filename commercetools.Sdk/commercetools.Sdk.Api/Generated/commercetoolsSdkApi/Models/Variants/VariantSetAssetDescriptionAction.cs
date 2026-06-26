using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetAssetDescriptionAction : IVariantSetAssetDescriptionAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public ILocalizedString Description { get; set; }
        public VariantSetAssetDescriptionAction()
        {
            this.Action = "setAssetDescription";
        }
    }
}
