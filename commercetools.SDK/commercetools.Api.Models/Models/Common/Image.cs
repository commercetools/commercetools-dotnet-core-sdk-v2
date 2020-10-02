using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class Image 
    {
        public string Url { get; set;}
        
        public ImageDimensions Dimensions { get; set;}
        
        public string Label { get; set;}
    }
}
