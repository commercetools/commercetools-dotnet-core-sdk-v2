using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.ProductTailorings
{

    public partial class ProductTailoringImport : IProductTailoringImport
    {
        public string Key { get; set; }

        public IStoreKeyReference Store { get; set; }

        public IProductKeyReference Product { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ILocalizedString Slug { get; set; }

        public bool? Publish { get; set; }

        public IList<IProductVariantTailoringImport> Variants { get; set; }

        public IEnumerable<IProductVariantTailoringImport> VariantsEnumerable { set => Variants = value.ToList(); }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }
    }
}
