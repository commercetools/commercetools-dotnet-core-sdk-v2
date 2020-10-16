using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Products
{
    public partial class ProductData 
    {
        public LocalizedString Name { get; set;}
        
        public List<CategoryReference> Categories { get; set;}
        
        public CategoryOrderHints CategoryOrderHints { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public LocalizedString Slug { get; set;}
        
        public LocalizedString MetaTitle { get; set;}
        
        public LocalizedString MetaDescription { get; set;}
        
        public LocalizedString MetaKeywords { get; set;}
        
        public ProductVariant MasterVariant { get; set;}
        
        public List<ProductVariant> Variants { get; set;}
        
        public SearchKeywords SearchKeywords { get; set;}
    }
}
