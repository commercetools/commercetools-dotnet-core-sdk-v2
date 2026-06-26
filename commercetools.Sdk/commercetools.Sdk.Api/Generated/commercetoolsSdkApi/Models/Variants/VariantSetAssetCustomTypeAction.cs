using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantSetAssetCustomTypeAction : IVariantSetAssetCustomTypeAction
    {
        public string Action { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public VariantSetAssetCustomTypeAction()
        {
            this.Action = "setAssetCustomType";
        }
    }
}
