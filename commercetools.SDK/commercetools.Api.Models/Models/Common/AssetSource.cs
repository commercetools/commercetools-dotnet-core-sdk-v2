using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class AssetSource 
    {
        public string Uri { get; set;}
        
        public string Key { get; set;}
        
        public AssetDimensions Dimensions { get; set;}
        
        public string ContentType { get; set;}
    }
}
