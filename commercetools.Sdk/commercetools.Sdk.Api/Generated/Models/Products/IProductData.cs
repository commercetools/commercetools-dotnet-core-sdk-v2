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
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductData))]
    public interface IProductData 
    {
        ILocalizedString Name { get; set;}
        
        List<ICategoryReference> Categories { get; set;}
        
        ICategoryOrderHints CategoryOrderHints { get; set;}
        
        ILocalizedString Description { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        ILocalizedString MetaTitle { get; set;}
        
        ILocalizedString MetaDescription { get; set;}
        
        ILocalizedString MetaKeywords { get; set;}
        
        IProductVariant MasterVariant { get; set;}
        
        List<IProductVariant> Variants { get; set;}
        
        ISearchKeywords SearchKeywords { get; set;}
    }
}
