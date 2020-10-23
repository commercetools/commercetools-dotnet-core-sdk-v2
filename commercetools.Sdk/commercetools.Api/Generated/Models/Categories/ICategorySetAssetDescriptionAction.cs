using commercetools.Api.Generated.Models.Categories;
using commercetools.Api.Generated.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Categories
{
    public interface ICategorySetAssetDescriptionAction : ICategoryUpdateAction
    {
        string AssetId { get; set;}
        
        string AssetKey { get; set;}
        
        ILocalizedString Description { get; set;}
    }
}
