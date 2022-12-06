using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Reviews;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductProjection))]
    public partial interface IProductProjection : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        string Key { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        IProductTypeReference ProductType { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString Slug { get; set; }

        IList<ICategoryReference> Categories { get; set; }
        IEnumerable<ICategoryReference> CategoriesEnumerable { set => Categories = value.ToList(); }


        ICategoryOrderHints CategoryOrderHints { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        ISearchKeywords SearchKeywords { get; set; }

        bool? HasStagedChanges { get; set; }

        bool? Published { get; set; }

        IProductVariant MasterVariant { get; set; }

        IList<IProductVariant> Variants { get; set; }
        IEnumerable<IProductVariant> VariantsEnumerable { set => Variants = value.ToList(); }


        ITaxCategoryReference TaxCategory { get; set; }

        IStateReference State { get; set; }

        IReviewRatingStatistics ReviewRatingStatistics { get; set; }

        IProductPriceModeEnum PriceMode { get; set; }

    }
}
