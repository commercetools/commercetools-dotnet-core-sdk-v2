using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public  partial class CategoryDraft : ICategoryDraft
    {
        public ILocalizedString Name { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public ICategoryResourceIdentifier Parent { get; set;}
        
        public string OrderHint { get; set;}
        
        public string ExternalId { get; set;}
        
        public ILocalizedString MetaTitle { get; set;}
        
        public ILocalizedString MetaDescription { get; set;}
        
        public ILocalizedString MetaKeywords { get; set;}
        
        public ICustomFieldsDraft Custom { get; set;}
        
        public List<IAssetDraft> Assets { get; set;}
        
        public string Key { get; set;}
    }
}
