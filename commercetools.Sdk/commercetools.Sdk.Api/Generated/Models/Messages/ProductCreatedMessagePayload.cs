using commercetools.Sdk.Api.Models.Products;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class ProductCreatedMessagePayload : IProductCreatedMessagePayload
    {
        public string Type { get; set; }

        public IProductProjection ProductProjection { get; set; }
        public ProductCreatedMessagePayload()
        {
            this.Type = "ProductCreated";
        }
    }
}
