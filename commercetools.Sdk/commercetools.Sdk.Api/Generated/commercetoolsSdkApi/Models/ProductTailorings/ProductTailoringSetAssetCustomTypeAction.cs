using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetAssetCustomTypeAction : IProductTailoringSetAssetCustomTypeAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public ProductTailoringSetAssetCustomTypeAction()
        {
            this.Action = "setAssetCustomType";
        }
    }
}
