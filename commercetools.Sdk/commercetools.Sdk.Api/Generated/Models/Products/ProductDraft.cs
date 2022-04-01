using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Products
{
    public partial class ProductDraft : IProductDraft
    {
        public IProductTypeResourceIdentifier ProductType { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Slug { get; set; }

        public string Key { get; set; }

        public ILocalizedString Description { get; set; }

        public List<ICategoryResourceIdentifier> Categories { get; set; }

        public ICategoryOrderHints CategoryOrderHints { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public IProductVariantDraft MasterVariant { get; set; }

        public List<IProductVariantDraft> Variants { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public ISearchKeywords SearchKeywords { get; set; }

        public IStateResourceIdentifier State { get; set; }

        public bool? Publish { get; set; }
    }
}
