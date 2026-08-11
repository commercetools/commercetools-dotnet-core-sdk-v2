using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductTailoringKeySetMessagePayload : IProductTailoringKeySetMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }

        public string ProductKey { get; set; }

        public IProductReference Product { get; set; }

        public string Key { get; set; }

        public string OldKey { get; set; }
        public ProductTailoringKeySetMessagePayload()
        {
            this.Type = "ProductTailoringKeySet";
        }
    }
}
