using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductData : IProductData
    {
        public ILocalizedString Name { get; set; }

        public IList<ICategoryReference> Categories { get; set; }

        public IEnumerable<ICategoryReference> CategoriesEnumerable { set => Categories = value.ToList(); }

        public ICategoryOrderHints CategoryOrderHints { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public IProductVariant MasterVariant { get; set; }

        public IList<IProductVariant> Variants { get; set; }

        public IEnumerable<IProductVariant> VariantsEnumerable { set => Variants = value.ToList(); }

        public ISearchKeywords SearchKeywords { get; set; }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }
    }
}
