using commercetools.Api.Generated.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Categories
{
    public interface ICategorySetAssetCustomFieldAction : ICategoryUpdateAction
    {
        string AssetId { get; set;}
        
        string AssetKey { get; set;}
        
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
