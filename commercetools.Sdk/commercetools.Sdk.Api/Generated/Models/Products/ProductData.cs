using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductData : IProductData
    {
        public ILocalizedString Name { get; set;}
        
        public List<ICategoryReference> Categories { get; set;}
        
        public ICategoryOrderHints CategoryOrderHints { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public ILocalizedString MetaTitle { get; set;}
        
        public ILocalizedString MetaDescription { get; set;}
        
        public ILocalizedString MetaKeywords { get; set;}
        
        public IProductVariant MasterVariant { get; set;}
        
        public List<IProductVariant> Variants { get; set;}
        
        public ISearchKeywords SearchKeywords { get; set;}
    }
}
