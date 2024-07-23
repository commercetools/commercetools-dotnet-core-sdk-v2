using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductPriceModeSetMessagePayload : IProductPriceModeSetMessagePayload
    {
        public string Type { get; set; }

        public IProductPriceModeEnum To { get; set; }
        public ProductPriceModeSetMessagePayload()
        {
            this.Type = "ProductPriceModeSet";
        }
    }
}
