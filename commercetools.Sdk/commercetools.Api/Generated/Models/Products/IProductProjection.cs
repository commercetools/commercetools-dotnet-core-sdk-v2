using commercetools.Api.Generated.Models.Categories;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductTypes;
using commercetools.Api.Generated.Models.Products;
using commercetools.Api.Generated.Models.Reviews;
using commercetools.Api.Generated.Models.States;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductProjection : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        string Key { get; set;}
        
        IProductTypeReference ProductType { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        List<ICategoryReference> Categories { get; set;}
        
        ICategoryOrderHints CategoryOrderHints { get; set;}
        
        ILocalizedString MetaTitle { get; set;}
        
        ILocalizedString MetaDescription { get; set;}
        
        ILocalizedString MetaKeywords { get; set;}
        
        ISearchKeywords SearchKeywords { get; set;}
        
        bool HasStagedChanges { get; set;}
        
        bool Published { get; set;}
        
        IProductVariant MasterVariant { get; set;}
        
        List<IProductVariant> Variants { get; set;}
        
        ITaxCategoryReference TaxCategory { get; set;}
        
        IStateReference State { get; set;}
        
        IReviewRatingStatistics ReviewRatingStatistics { get; set;}
    }
}
