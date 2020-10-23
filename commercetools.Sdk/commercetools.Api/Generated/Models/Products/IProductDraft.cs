using commercetools.Api.Generated.Models.Categories;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductTypes;
using commercetools.Api.Generated.Models.Products;
using commercetools.Api.Generated.Models.States;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Products
{
    public interface IProductDraft 
    {
        IProductTypeResourceIdentifier ProductType { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        string Key { get; set;}
        
        ILocalizedString Description { get; set;}
        
        List<ICategoryResourceIdentifier> Categories { get; set;}
        
        ICategoryOrderHints CategoryOrderHints { get; set;}
        
        ILocalizedString MetaTitle { get; set;}
        
        ILocalizedString MetaDescription { get; set;}
        
        ILocalizedString MetaKeywords { get; set;}
        
        IProductVariantDraft MasterVariant { get; set;}
        
        List<IProductVariantDraft> Variants { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        ISearchKeywords SearchKeywords { get; set;}
        
        IStateResourceIdentifier State { get; set;}
        
        bool Publish { get; set;}
    }
}
