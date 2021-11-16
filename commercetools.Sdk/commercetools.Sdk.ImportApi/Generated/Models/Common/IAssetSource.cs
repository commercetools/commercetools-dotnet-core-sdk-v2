using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Common.AssetSource))]
    public partial interface IAssetSource 
    {
        string Uri { get; set;}
        
        string Key { get; set;}
        
        IAssetDimensions Dimensions { get; set;}
        
        string ContentType { get; set;}
    }
}
