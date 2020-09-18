using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public class ProductDraft 
    {
        public ProductTypeResourceIdentifier ProductType { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Slug { get; set;}
        
        public string Key { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public List<CategoryResourceIdentifier> Categories { get; set;}
        
        public CategoryOrderHints CategoryOrderHints { get; set;}
        
        public LocalizedString MetaTitle { get; set;}
        
        public LocalizedString MetaDescription { get; set;}
        
        public LocalizedString MetaKeywords { get; set;}
        
        public ProductVariantDraft MasterVariant { get; set;}
        
        public List<ProductVariantDraft> Variants { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public SearchKeywords SearchKeywords { get; set;}
        
        public StateResourceIdentifier State { get; set;}
        
        public bool Publish { get; set;}
    }
}
