namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class ProductUnpublishedMessagePayload : IProductUnpublishedMessagePayload
    {
        public string Type { get; set; }
        public ProductUnpublishedMessagePayload()
        {
            this.Type = "ProductUnpublished";
        }
    }
}
