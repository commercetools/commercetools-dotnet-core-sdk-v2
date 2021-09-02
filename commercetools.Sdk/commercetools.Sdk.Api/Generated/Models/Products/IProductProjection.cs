using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductProjection))]
    public partial interface IProductProjection : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        string Key { get; set; }

        IProductTypeReference ProductType { get; set; }

        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        ILocalizedString Slug { get; set; }

        List<ICategoryReference> Categories { get; set; }

        ICategoryOrderHints CategoryOrderHints { get; set; }

        ILocalizedString MetaTitle { get; set; }

        ILocalizedString MetaDescription { get; set; }

        ILocalizedString MetaKeywords { get; set; }

        ISearchKeywords SearchKeywords { get; set; }

        bool? HasStagedChanges { get; set; }

        bool? Published { get; set; }

        IProductVariant MasterVariant { get; set; }

        List<IProductVariant> Variants { get; set; }

        ITaxCategoryReference TaxCategory { get; set; }

        IStateReference State { get; set; }

        IReviewRatingStatistics ReviewRatingStatistics { get; set; }
    }
}
