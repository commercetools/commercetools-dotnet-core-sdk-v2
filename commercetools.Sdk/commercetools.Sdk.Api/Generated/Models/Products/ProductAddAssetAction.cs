using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductAddAssetAction : IProductAddAssetAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public IAssetDraft Asset { get; set; }

        public int? Position { get; set; }
        public ProductAddAssetAction()
        {
            this.Action = "addAsset";
        }
    }
}
