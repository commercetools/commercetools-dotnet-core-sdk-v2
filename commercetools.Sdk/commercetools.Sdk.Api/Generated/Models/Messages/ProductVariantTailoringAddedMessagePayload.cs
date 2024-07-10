using commercetools.Sdk.Api.Models.ProductTailorings;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductVariantTailoringAddedMessagePayload : IProductVariantTailoringAddedMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }

        public string ProductKey { get; set; }

        public IProductReference Product { get; set; }

        public long VariantId { get; set; }

        public IProductVariantTailoring Variant { get; set; }
        public ProductVariantTailoringAddedMessagePayload()
        {
            this.Type = "ProductVariantTailoringAdded";
        }
    }
}
