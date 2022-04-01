namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductLegacySetSkuAction : IProductLegacySetSkuAction
    {
        public string Action { get; set; }

        public string Sku { get; set; }

        public int VariantId { get; set; }
        public ProductLegacySetSkuAction()
        {
            this.Action = "legacySetSku";
        }
    }
}
