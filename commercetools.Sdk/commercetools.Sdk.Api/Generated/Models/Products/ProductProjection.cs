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
    public  partial class ProductProjection : IProductProjection
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public string Key { get; set;}
        
        public IProductTypeReference ProductType { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public List<ICategoryReference> Categories { get; set;}
        
        public ICategoryOrderHints CategoryOrderHints { get; set;}
        
        public ILocalizedString MetaTitle { get; set;}
        
        public ILocalizedString MetaDescription { get; set;}
        
        public ILocalizedString MetaKeywords { get; set;}
        
        public ISearchKeywords SearchKeywords { get; set;}
        
        public bool? HasStagedChanges { get; set;}
        
        public bool? Published { get; set;}
        
        public IProductVariant MasterVariant { get; set;}
        
        public List<IProductVariant> Variants { get; set;}
        
        public ITaxCategoryReference TaxCategory { get; set;}
        
        public IStateReference State { get; set;}
        
        public IReviewRatingStatistics ReviewRatingStatistics { get; set;}
    }
}
