using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantAddAssetAction : IVariantAddAssetAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public IAssetDraft Asset { get; set; }

        public int? Position { get; set; }
        public VariantAddAssetAction()
        {
            this.Action = "addAsset";
        }
    }
}
