

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductRemoveAssetAction : IProductRemoveAssetAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }
        public ProductRemoveAssetAction()
        {
            this.Action = "removeAsset";
        }
    }
}
