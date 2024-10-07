

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetAssetKeyAction : IProductTailoringSetAssetKeyAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }
        public ProductTailoringSetAssetKeyAction()
        {
            this.Action = "setAssetKey";
        }
    }
}
