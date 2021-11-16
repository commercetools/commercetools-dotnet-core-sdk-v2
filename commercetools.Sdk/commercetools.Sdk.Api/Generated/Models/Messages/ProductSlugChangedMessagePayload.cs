using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductSlugChangedMessagePayload : IProductSlugChangedMessagePayload
    {
        public string Type { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString OldSlug { get; set; }
        public ProductSlugChangedMessagePayload()
        {
            this.Type = "ProductSlugChanged";
        }
    }
}
