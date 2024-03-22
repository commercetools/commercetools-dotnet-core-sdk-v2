using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Stores;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringDraft : IProductTailoringDraft
    {
        public string Key { get; set; }

        public IStoreResourceIdentifier Store { get; set; }

        public IProductResourceIdentifier Product { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ILocalizedString Slug { get; set; }

        public bool? Publish { get; set; }
    }
}
