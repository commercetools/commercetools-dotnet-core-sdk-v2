using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Categories
{
    public partial class Category : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Slug { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public List<CategoryReference> Ancestors { get; set;}
        
        public CategoryReference Parent { get; set;}
        
        public string OrderHint { get; set;}
        
        public string ExternalId { get; set;}
        
        public LocalizedString MetaTitle { get; set;}
        
        public LocalizedString MetaDescription { get; set;}
        
        public LocalizedString MetaKeywords { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public List<Asset> Assets { get; set;}
        
        public string Key { get; set;}
    }
}
