using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.AssetDraft))]
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
