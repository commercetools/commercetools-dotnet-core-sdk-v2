using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringData : IProductTailoringData
    {
        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ILocalizedString Slug { get; set; }

        public IList<IProductVariantTailoring> Variants { get; set; }

        public IEnumerable<IProductVariantTailoring> VariantsEnumerable { set => Variants = value.ToList(); }
    }
}
