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
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.Category))]
    public interface ICategory : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        ILocalizedString Description { get; set;}
        
        List<ICategoryReference> Ancestors { get; set;}
        
        ICategoryReference Parent { get; set;}
        
        string OrderHint { get; set;}
        
        string ExternalId { get; set;}
        
        ILocalizedString MetaTitle { get; set;}
        
        ILocalizedString MetaDescription { get; set;}
        
        ILocalizedString MetaKeywords { get; set;}
        
        ICustomFields Custom { get; set;}
        
        List<IAsset> Assets { get; set;}
        
        string Key { get; set;}
    }
}
