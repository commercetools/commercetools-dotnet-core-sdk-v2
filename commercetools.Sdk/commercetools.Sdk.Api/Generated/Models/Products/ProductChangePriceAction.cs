namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductChangePriceAction : IProductChangePriceAction
    {
        public string Action { get; set; }

        public string PriceId { get; set; }

        public IEmbeddedPriceDraft Price { get; set; }

        public bool? Staged { get; set; }
        public ProductChangePriceAction()
        {
            this.Action = "changePrice";
        }
    }
}
