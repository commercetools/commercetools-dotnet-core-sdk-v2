using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Products
{
    public partial class ProductImport : IProductImport
    {
        public string Key { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public IProductTypeKeyReference ProductType { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public List<ICategoryKeyReference> Categories { get; set;}
        
        public ILocalizedString MetaTitle { get; set;}
        
        public ILocalizedString MetaDescription { get; set;}
        
        public ILocalizedString MetaKeywords { get; set;}
        
        public ITaxCategoryKeyReference TaxCategory { get; set;}
        
        public ISearchKeywords SearchKeywords { get; set;}
        
        public IStateKeyReference State { get; set;}
        
        public bool? Publish { get; set;}
    }
}
