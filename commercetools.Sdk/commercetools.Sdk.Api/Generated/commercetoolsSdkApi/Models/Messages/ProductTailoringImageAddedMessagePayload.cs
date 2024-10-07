using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductTailoringImageAddedMessagePayload : IProductTailoringImageAddedMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }

        public string ProductKey { get; set; }

        public IProductReference Product { get; set; }

        public long VariantId { get; set; }

        public IImage Image { get; set; }
        public ProductTailoringImageAddedMessagePayload()
        {
            this.Type = "ProductTailoringImageAdded";
        }
    }
}
