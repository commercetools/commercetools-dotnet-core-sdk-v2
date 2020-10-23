using commercetools.Api.Generated.Models.Categories;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Categories
{
    public interface ICategoryDraft 
    {
        ILocalizedString Name { get; set;}
        
        ILocalizedString Slug { get; set;}
        
        ILocalizedString Description { get; set;}
        
        ICategoryResourceIdentifier Parent { get; set;}
        
        string OrderHint { get; set;}
        
        string ExternalId { get; set;}
        
        ILocalizedString MetaTitle { get; set;}
        
        ILocalizedString MetaDescription { get; set;}
        
        ILocalizedString MetaKeywords { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        List<IAssetDraft> Assets { get; set;}
        
        string Key { get; set;}
    }
}
