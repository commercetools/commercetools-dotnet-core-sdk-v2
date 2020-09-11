using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class AssetSource 
    {
        public string Uri { get; set;}
        
        public string Key { get; set;}
        
        public AssetDimensions Dimensions { get; set;}
        
        public string ContentType { get; set;}
    }
}
