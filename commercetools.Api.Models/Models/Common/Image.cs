using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class Image 
    {
        public string Url { get; set;}
        
        public ImageDimensions Dimensions { get; set;}
        
        public string Label { get; set;}
    }
}
