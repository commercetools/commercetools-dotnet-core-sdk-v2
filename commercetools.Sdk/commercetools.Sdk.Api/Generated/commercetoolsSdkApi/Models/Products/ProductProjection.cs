using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductProjection : IProductProjection
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public IProductTypeReference ProductType { get; set; }

        public ILocalizedString Name { get; set; }

        public ILocalizedString Description { get; set; }

        public ILocalizedString Slug { get; set; }

        public IList<ICategoryReference> Categories { get; set; }

        public IEnumerable<ICategoryReference> CategoriesEnumerable { set => Categories = value.ToList(); }

        public ICategoryOrderHints CategoryOrderHints { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public ILocalizedString MetaDescription { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public ISearchKeywords SearchKeywords { get; set; }

        public bool? HasStagedChanges { get; set; }

        public bool? Published { get; set; }

        public IProductVariant MasterVariant { get; set; }

        public IList<IProductVariant> Variants { get; set; }

        public IEnumerable<IProductVariant> VariantsEnumerable { set => Variants = value.ToList(); }

        public ITaxCategoryReference TaxCategory { get; set; }

        public IStateReference State { get; set; }

        public IReviewRatingStatistics ReviewRatingStatistics { get; set; }

        public IProductPriceModeEnum PriceMode { get; set; }

        public IList<IAttribute> Attributes { get; set; }

        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }
    }
}
