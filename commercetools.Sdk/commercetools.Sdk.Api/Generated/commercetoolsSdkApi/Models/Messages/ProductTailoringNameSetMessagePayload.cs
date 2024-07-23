using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductTailoringNameSetMessagePayload : IProductTailoringNameSetMessagePayload
    {
        public string Type { get; set; }

        public IStoreKeyReference Store { get; set; }

        public string ProductKey { get; set; }

        public IProductReference Product { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString OldName { get; set; }
        public ProductTailoringNameSetMessagePayload()
        {
            this.Type = "ProductTailoringNameSet";
        }
    }
}
