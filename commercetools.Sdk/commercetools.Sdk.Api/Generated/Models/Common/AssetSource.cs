using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class AssetSource : IAssetSource
    {
        public string Uri { get; set;}
        
        public string Key { get; set;}
        
        public IAssetDimensions Dimensions { get; set;}
        
        public string ContentType { get; set;}
    }
}
