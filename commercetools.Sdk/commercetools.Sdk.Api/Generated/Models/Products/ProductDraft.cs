using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.States;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductDraft : IProductDraft
    {
        public IProductTypeResourceIdentifier ProductType { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public string Key { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public List<ICategoryResourceIdentifier> Categories { get; set;}
        
        public ICategoryOrderHints CategoryOrderHints { get; set;}
        
        public ILocalizedString MetaTitle { get; set;}
        
        public ILocalizedString MetaDescription { get; set;}
        
        public ILocalizedString MetaKeywords { get; set;}
        
        public IProductVariantDraft MasterVariant { get; set;}
        
        public List<IProductVariantDraft> Variants { get; set;}
        
        public ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public ISearchKeywords SearchKeywords { get; set;}
        
        public IStateResourceIdentifier State { get; set;}
        
        public bool? Publish { get; set;}
    }
}
