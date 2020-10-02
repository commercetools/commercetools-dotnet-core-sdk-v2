using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    public partial class CategoryDraft 
    {
        public LocalizedString Name { get; set;}
        
        public LocalizedString Slug { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public CategoryResourceIdentifier Parent { get; set;}
        
        public string OrderHint { get; set;}
        
        public string ExternalId { get; set;}
        
        public LocalizedString MetaTitle { get; set;}
        
        public LocalizedString MetaDescription { get; set;}
        
        public LocalizedString MetaKeywords { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public List<AssetDraft> Assets { get; set;}
        
        public string Key { get; set;}
    }
}
