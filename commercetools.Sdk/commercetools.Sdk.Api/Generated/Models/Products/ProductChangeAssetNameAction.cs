using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductChangeAssetNameAction : IProductChangeAssetNameAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public ILocalizedString Name { get; set; }
        public ProductChangeAssetNameAction()
        {
            this.Action = "changeAssetName";
        }
    }
}
