using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringAddAssetAction : IProductTailoringAddAssetAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public IAssetDraft Asset { get; set; }

        public int? Position { get; set; }
        public ProductTailoringAddAssetAction()
        {
            this.Action = "addAsset";
        }
    }
}
