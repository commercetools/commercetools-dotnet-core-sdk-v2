using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringInStoreDraft : IProductTailoringInStoreDraft
    {
        public string Key { get; set; }

        public IProductResourceIdentifier Product { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ILocalizedString Slug { get; set; }

        public bool? Publish { get; set; }

        public IList<IProductVariantTailoringDraft> Variants { get; set; }
        public IEnumerable<IProductVariantTailoringDraft> VariantsEnumerable { set => Variants = value.ToList(); }

    }
}
