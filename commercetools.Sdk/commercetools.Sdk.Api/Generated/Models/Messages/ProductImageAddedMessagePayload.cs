using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductImageAddedMessagePayload : IProductImageAddedMessagePayload
    {
        public string Type { get; set; }

        public long VariantId { get; set; }

        public IImage Image { get; set; }

        public bool Staged { get; set; }
        public ProductImageAddedMessagePayload()
        {
            this.Type = "ProductImageAdded";
        }
    }
}
