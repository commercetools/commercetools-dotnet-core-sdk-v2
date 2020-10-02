using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Reviews;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductProjection : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public string Key { get; set;}
        
        public ProductTypeReference ProductType { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public LocalizedString Slug { get; set;}
        
        public List<CategoryReference> Categories { get; set;}
        
        public CategoryOrderHints CategoryOrderHints { get; set;}
        
        public LocalizedString MetaTitle { get; set;}
        
        public LocalizedString MetaDescription { get; set;}
        
        public LocalizedString MetaKeywords { get; set;}
        
        public SearchKeywords SearchKeywords { get; set;}
        
        public bool HasStagedChanges { get; set;}
        
        public bool Published { get; set;}
        
        public ProductVariant MasterVariant { get; set;}
        
        public List<ProductVariant> Variants { get; set;}
        
        public TaxCategoryReference TaxCategory { get; set;}
        
        public StateReference State { get; set;}
        
        public ReviewRatingStatistics ReviewRatingStatistics { get; set;}
    }
}
