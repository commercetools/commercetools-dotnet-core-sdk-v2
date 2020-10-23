using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Common
{
    public interface IAssetDraft 
    {
        List<IAssetSource> Sources { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ILocalizedString Description { get; set;}
        
        List<string> Tags { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        string Key { get; set;}
    }
}
