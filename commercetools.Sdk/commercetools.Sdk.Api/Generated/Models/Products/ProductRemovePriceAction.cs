using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductRemovePriceAction : IProductRemovePriceAction
    {
        public string Action { get; set; }

        public string PriceId { get; set; }

        public string Sku { get; set; }

        public long? VariantId { get; set; }

        public IPriceDraft Price { get; set; }

        public bool? Staged { get; set; }
        public ProductRemovePriceAction()
        {
            this.Action = "removePrice";
        }
    }
}
