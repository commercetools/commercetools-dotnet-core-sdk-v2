namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductAddPriceAction : IProductAddPriceAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public IEmbeddedPriceDraft Price { get; set; }

        public bool? Staged { get; set; }
        public ProductAddPriceAction()
        {
            this.Action = "addPrice";
        }
    }
}
