using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductData : IProductData
    {
        public ILocalizedString Name { get; set; }

        public List<ICategoryReference> Categories { get; set; }

        public ICategoryOrderHints CategoryOrderHints { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString Slug { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public IProductVariant MasterVariant { get; set; }

        public List<IProductVariant> Variants { get; set; }

        public ISearchKeywords SearchKeywords { get; set; }
    }
}
