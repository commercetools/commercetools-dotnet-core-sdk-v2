namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductSetPriceModeAction : IProductSetPriceModeAction
    {
        public string Action { get; set; }

        public IProductPriceModeEnum PriceMode { get; set; }
        public ProductSetPriceModeAction()
        {
            this.Action = "setPriceMode";
        }
    }
}
