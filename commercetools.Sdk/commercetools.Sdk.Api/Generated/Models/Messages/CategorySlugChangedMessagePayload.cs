using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class CategorySlugChangedMessagePayload : ICategorySlugChangedMessagePayload
    {
        public string Type { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString OldSlug { get; set; }
        public CategorySlugChangedMessagePayload()
        {
            this.Type = "CategorySlugChanged";
        }
    }
}
